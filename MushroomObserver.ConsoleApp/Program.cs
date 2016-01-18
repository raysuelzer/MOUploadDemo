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
            Console.WriteLine("Enter your apikey and press enter");

            string key = Console.ReadLine();

            var uploader = new NamaBulkUploadService("3bi7qrfiq2gnag616conwv3qbz9fvf5p");
            uploader.Run();
            Console.ReadLine();
        }
    }
}
