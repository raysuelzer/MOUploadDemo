namespace MushroomObserver.APIService.Models
{
    public class CreateObservationResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public bool IsAmbiguous { get; set; }
        public string[] AmbiguousMatches { get; set; }
    }
}
