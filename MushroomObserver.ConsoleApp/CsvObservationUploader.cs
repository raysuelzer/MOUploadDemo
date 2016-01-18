using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using MushroomObserver.APIService.Models;
using MushroomObserver.APIService.Services;

namespace MushroomObserver.ConsoleApp
{
    public class CsvObservationUploader
    {
        private List<NAMASpreadsheet> RecordsToUpload { get; }

        private DirectoryInfo ImageDirectoryInfo { get; }

        private MushroomObserverApiService ApiService { get; }

        private Configuration Configuration { get; }

        private ILogger Logger { get; }
        
        public CsvObservationUploader(Configuration configuration, ILogger logger, MushroomObserverApiService apiService)
        {
            Configuration = configuration;
            ApiService = apiService;
            Logger = logger;
            ImageDirectoryInfo = new DirectoryInfo(configuration.ImageDirectory);
            using (var reader = File.OpenText(configuration.ObservationCsvFile))
            {
                var csv = new CsvReader(reader);
                RecordsToUpload = csv.GetRecords<NAMASpreadsheet>().ToList().Where(r => GetImagePaths(r.RecordNumber).Any()).ToList();
            }
        }

        private void LogError(string recordNumber, string message)
        {
            Logger.LogError($"{recordNumber} --- {message}");
        }
        public void Run()
        {
            foreach (var record in RecordsToUpload)
            {
                try
                {
                    Logger.Log($"Uploading record {record.RecordNumber}");

                    var result = ApiService.CreateObservation(CreateObservationModel(record));
                    if (result == null)
                    {
                        LogError(record.RecordNumber, "Failed to create observation");
                        continue;
                    }
                    if (result.Success == false)
                    {
                        LogError(record.RecordNumber, result.Message);
                    }
                    if (result.Success)
                    {
                        UploadImages(record.RecordNumber, result.Message);
                    }
                }
                catch(Exception ex)
                {
                    LogError(record?.RecordNumber, ex.Message);
                }
            }
        }

        public List<string> GetImagePaths(string namaRecordNumber)
        {
            return ImageDirectoryInfo.GetFiles("*.JPG").Where(file => file.Name.Contains("-" + namaRecordNumber)).Select(x => x.FullName).ToList();
        }

        private void UploadImages(string namaRecordNumber, string observationId)
        {
            var images = GetImagePaths(namaRecordNumber);
            foreach (var image in images)
            {
                Logger.Log($"Uploading {image}");
                if (ApiService.UploadImage(observationId, image) == 0)
                {
                    Logger.LogError($"Could not upload {image}");
                }
            }
        }

        private PostObservationModel CreateObservationModel(NAMASpreadsheet spreadsheetItem)
        {
          return  new PostObservationModel()
            {
                Altitude = "0",
                Confidence = "3.0",
                Latitude = "",
                Longitude = "",
                Date = Configuration.ObservationDate.ToString("yyyy-MM-dd"),
                HasSpecimen = "1",
                Location = Configuration.Location,
                Name = spreadsheetItem.Taxon.Trim(),
                Notes = spreadsheetItem.GetNotes()
            };
            
            
        }
    }
}
