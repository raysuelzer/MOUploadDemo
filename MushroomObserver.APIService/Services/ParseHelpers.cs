using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MushroomObserver.APIService.Services
{
    public static class ParseHelpers
    {

        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static T ParseXML<T>(this string @this) where T : class
        {
            var settings = new XmlReaderSettings()
            {
                ConformanceLevel = ConformanceLevel.Auto
            };

            var reader = XmlReader.Create(@this.Trim().ToStream(), settings);
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
            

        }
    }
}