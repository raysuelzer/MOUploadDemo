using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MushroomObserver.APIService.Models;
using MushroomObserver.APIService.Services;

namespace MushroomObserver.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upload Observation Demo");
            var _uploadService = new MushroomObserverApiService();

            var observationToCreate = new PostObservationModel()
            {
                Altitude = "0",
                Confidence = "3.0",
                Date = "2015-08-06",
                HasSpecimen = "false", //this might be a 0 or 1? I can't remember
                Latitude = "40.0",
                Longitude = "40.0",
                Location = "Anywhere, CA, USA",
                Name = "Conocybe Apala",
                Notes = "This is a test"
            };

            var response = _uploadService.CreateObservation("myapikey", observationToCreate);

            if (response.Success)
            {
                var createdObservationId = response.Message;
                _uploadService.UploadImage("myapiKey", createdObservationId, DateTime.Now, "myimage.jpg",
                    @"c:\my_images");
            }

            else
            {
                Console.WriteLine("There as an error!");
                Console.WriteLine(response.Message);
                if (response.IsAmbiguous)
                {
                    Console.WriteLine("looks likes this name is ambiguous, did you mean:");
                    foreach (var match in response.AmbiguousMatches)
                    {
                        Console.WriteLine(match);
                    }
                }

            }

            Console.ReadKey();

        }
    }
}
