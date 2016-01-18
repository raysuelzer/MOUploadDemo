using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using MushroomObserver.APIService.Models;
using RestSharp;
using RestSharp.Contrib;

namespace MushroomObserver.APIService.Services
{
    public class MushroomObserverApiService
    {
        private RestClient RestClient { get; }

        private string ApiKey { get; }

        private string Endpoint { get; }
        public MushroomObserverApiService(Uri endpoint, string apiKey)
        {
            Endpoint = endpoint.AbsoluteUri;
            RestClient = new RestClient(endpoint);
            ApiKey = apiKey;
        }

        ////api/observations
        public CreateObservationResponse CreateObservation(PostObservationModel model)
        {
            if (String.IsNullOrWhiteSpace(model.Name))
                model.Name = "Fungi";

            var postUri = "observations?" + ConstructQueryString(model);


            var request = new RestRequest(postUri, Method.POST);
            var response = RestClient.Execute(request);


            var result = response.Content.ParseXML<XMLResponseModels.ApiResponse>();

            if (result.Errors != null)
            {
                return new CreateObservationResponse()
                {
                    Success = false,
                    Message = result.Errors.Items.FirstOrDefault()?.Details
                };
            }
            return new CreateObservationResponse()
            {
                Success = true,
                Message = result.Results?.Items?.FirstOrDefault()?.Id.ToString()
            };
        }

        private string ConstructQueryString(PostObservationModel model)
        {

            var queryParams = new NameValueCollection();
            queryParams.Add("api_key", ApiKey);
            queryParams.Add("date", model.Date);
            queryParams.Add("location", model.Location);
            queryParams.Add("notes", model.Notes);
            queryParams.Add("has_specimen", model.HasSpecimen);
            queryParams.Add("name", model.Name);
            queryParams.Add("vote", model.Confidence);
            queryParams.Add("log", "no");

            var items = new List<string>();

            foreach (string name in queryParams)
            {
                items.Add(string.Concat(name, "=", HttpUtility.UrlEncode(queryParams[name])));
            }

            return string.Join("&", items);
        }

        ///api/image
        public int UploadImage(string observationId, string filePath)
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

                var postUri = "images?api_key=" + ApiKey;
                postUri += "&observations=" + observationId;


                var request = (HttpWebRequest)WebRequest.Create(Endpoint + "/" + postUri);
                request.Method = "POST";
                request.Headers.Add("Content-MD5", md5Value);
                request.ContentLength = data.Length;
                request.ContentType = "image/jpeg";

                Stream newStream = request.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                WebResponse myWebResponse = request.GetResponse();
                var responseBody = new StreamReader(myWebResponse.GetResponseStream()).ReadToEnd();
                var result = responseBody.ParseXML<XMLResponseModels.ApiResponse>();
                return result.Results.Items[0].Id;
            }
            catch
            {
                return 0;
            }
        }
    }
}


