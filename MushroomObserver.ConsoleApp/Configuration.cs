using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushroomObserver.ConsoleApp
{
    public class Configuration
    {
        public DateTime ObservationDate { get; set; }

        public string Location { get; set; }

        public string ObservationCsvFile { get; set; }

        public string ImageDirectory { get; set; }

        public string LogFile { get; set; }

    }
}
