using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushroomObserver.ConsoleApp
{
    public class NAMASpreadsheet
    {
        public string RecordNumber { get; set; }
        public string Taxon { get; set; }

        public string Voucher { get; set; }

        public string IdentifiedBy { get; set; }

        public string CollectedBy { get; set; }

        public string Herbarium { get; set; }

    }

    public static class NamaExtensions
    {
        public static string GetNotes(this NAMASpreadsheet item)
        {
            return $"{item.Voucher} {item.IdentifiedBy} {item.CollectedBy} {item.Herbarium}";
        }
    }
}
