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
            try
            {
                Console.WriteLine("Enter your apikey and press enter");

                string key = Console.ReadLine();

                var uploader = new NamaBulkUploadService(key);
                uploader.Run();
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
