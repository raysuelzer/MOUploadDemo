using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;
using MushroomObserver.APIService.Models;
using RestSharp;

namespace MushroomObserver.APIService.Services
{
    public class MushroomObserverApiService
    {
        private RestClient _restClient;
        public MushroomObserverApiService()
        {
            _restClient = new RestClient("http://mushroomobserver.org/api");
        }

        ////api/observations
        
        //[GET]
        public response GetObservations(Dictionary<string, string> parameters)
        {
            var request = new RestRequest("observations", Method.GET);
            request.AddParameter("detail", "high"); // replaces matching token in request.Resource
            foreach (var param in parameters)
            {
                request.AddParameter(param.Key, param.Value);
            }

            var response = _restClient.Execute(request);
            try
            {
                return response.Content.ParseXML<response>();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public responseResultsResult GetObservationById(string observationId)
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("id", observationId);
            var response = GetObservations(dictionary);

            try
            {
                return response.results.result[0];
            }
            catch
            {
                return null;
            }
        }

        public List<int> GetObservationImages(int id)
        {
            var request = new RestRequest("observations", Method.GET);
            request.AddParameter("id", id); // replaces matching token in request.Resource
            request.AddParameter("detail", "high"); // replaces matching token in request.Resource
           

            // execute the request
            var response = _restClient.Execute(request);
            var data = response.Content.ParseXML<response>();
            try
            {
                var images = data.results.result[0].images.image.ToList().Select(p => (int) p.id).ToList();
                images.Add((int) data.results.result[0].primary_image.id);
                return images;
            }
            catch
            {
                return Enumerable.Empty<int>().ToList();
            }
        }

        public CreateObservationResponse CreateObservation(string apiKey, PostObservationModel model)
        {
            if (String.IsNullOrWhiteSpace(model.Name))
                model.Name = "Fungi";
                var postUri = "observations?api_key=" + apiKey;
                postUri += "&date=" + model.Date;
                postUri += "&location=" + model.Location;
                postUri += "&notes=" + model.Notes;
                postUri += "&latitude=" + model.Latitude;
                postUri += "&longitude=" + model.Longitude;
                postUri += "&has_specimen=" + model.HasSpecimen;
                postUri += "&name=" + model.Name;
                postUri += "&vote=" + model.Confidence;
                postUri += "&log=no";

                var request = new RestRequest(postUri, Method.POST);
                var response = _restClient.Execute(request);

                try
                {
                    var result = response.Content.ParseXML<response>();
                    var observationId = result.results.result[0].id;  //will fail here if it was not created correctly.
                    return new CreateObservationResponse()
                    {
                        Success = true,
                        Message = observationId.ToString()
                    };

                }
                catch
                {
                    var result = response.Content.ParseXML<errorResponse>();
                    if (result.errors.error.code.Contains("AmbiguousName"))
                    {
                        var amibDetails = result.errors.error.details;
                            amibDetails = amibDetails.Remove(amibDetails.LastIndexOf('.'));
                        return new CreateObservationResponse()
                        {
                            Success = false,
                            IsAmbiguous = true,
                            Message = "Name is ambiguous",
                            AmbiguousMatches = amibDetails.Substring(amibDetails.IndexOf(", matches ") + 10).Split('/').Select(x => x.Trim(' ')).ToArray()
                        };
                    }
                    return null;
                }
        }

        public void ProposeName(string apiKey, string observationId, string proposedName, string vote, string reason)
        {
            //var request = new RestRequest(postUri, Method.POST);
            //var response = _restClient.Execute(request);
        }
        
        ///api/image
        public long UploadImage(string apiKey, string observationId, DateTime date, string filename, string filePath)
        {
            try
            {
                byte[] data = File.ReadAllBytes(filePath);

                string md5Value = string.Empty;
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        md5Value = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }

                var postUri = "images?api_key=" + apiKey;
                postUri += "&observations=" + observationId;

                var request = (HttpWebRequest) WebRequest.Create("http://mushroomobserver.org/api/" + postUri);
                request.Method = "POST";
                request.Headers.Add("Content-MD5", md5Value);
                request.ContentLength = data.Length;
                request.ContentType = "image/jpeg";

                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                WebResponse myWebResponse = request.GetResponse();
                var responseBody = new StreamReader(myWebResponse.GetResponseStream()).ReadToEnd();
                var result = responseBody.ParseXML<response>();
                return result.results.result[0].id;
            }
            catch
            {
                return 0;
            }
        }
    }

    public static class ParseHelpers
    {

        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static T ParseXML<T>(this string @this) where T : class
        {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }
    }
}


