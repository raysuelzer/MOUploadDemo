using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using MushroomObserver.APIService.Services;

namespace MushroomObserver.ConsoleApp
{
    public class NamaBulkUploadService
    {
        private List<Configuration> Configurations { get; }

        private string ApiKey { get; }

        public NamaBulkUploadService(string apiKey)
        {
            Configurations = LoadConfiguration();
            ApiKey = apiKey;
        }

        public List<Configuration> LoadConfiguration()
        {
            using (var reader = File.OpenText("configuration.csv"))
            {
                var csv = new CsvReader(reader);
                return csv.GetRecords<Configuration>().ToList();
            }
        }

        public void Run()
        {
            foreach (var configuration in Configurations)
            {
                Run(configuration);
            }
        }

        private void Run(Configuration configuration)
        {
            #if DEBUG
            var url = "http://localhost:3000/api";
            #else
            var url = "http://mushroomobserver.org/api";
            #endif

            var apiService = new MushroomObserverApiService(new Uri(url), ApiKey);
            var logger = new FileLogger(configuration.LogFile);
            var uploader = new CsvObservationUploader(configuration, logger, apiService);
            logger.Log($"Starting upload for {configuration.ObservationCsvFile}");
            uploader.Run();
        }
    }
}