using System.Collections.Specialized;

namespace MushroomObserver.APIService.Models
{
    public class PostObservationModel
    {
        public string Date { get; set; }  //"yyyy-MM-dd"
        public string Location { get; set; }
        public string Notes { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Altitude { get; set; }
        public string HasSpecimen { get; set; }
        public string Name { get; set; }
        public string Confidence { get; set; }
    }
}
