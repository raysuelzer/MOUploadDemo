using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MushroomObserver.APIService.Models
{
    public class XMLResponseModels
    {

#if DEBUG
        [XmlRoot(ElementName = "response", Namespace = "http://localhost:3000/response.xsd")]
#else
        [XmlRoot(ElementName = "response", Namespace = "http://mushroomobserver.org/response.xsd")]
#endif
        public class ApiResponse
        {
            [XmlElement("version")]
            public Version Version { get; set; }

            [XmlElement("results", IsNullable = true)]
            public ApiResponseResults Results { get; set; }

            [XmlElement("errors", IsNullable = true)]
            public ApiResponseErrors Errors { get; set; }
        }

        public class Version
        {
            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlAttribute("content_type")]
            public string ContentType { get; set; }

            [XmlText(typeof(decimal))]
            public decimal Value { get; set; }
        }

        public class ApiResponseResults
        {
            [XmlAttribute("number")]
            public int Count { get; set; }
            
            [XmlElement("result")]
            public ApiResult[] Items { get; set; }

        }


        public class ApiResult
        {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlAttribute("url")]
            public string Url { get; set; }

            [XmlAttribute("type")]
            public string Type { get; set; }
        }


        public class ApiResponseErrors
        {
            [XmlAttribute("number")]
            public int Count { get; set; }

            [XmlElement("error")]
            public ApiError[] Items { get; set; }

        }

        public class ApiError
        {
            [XmlAttribute("id")]
            public int Id { get; set; }
            
            [XmlElement("code")]
            public string Code { get; set; }

            [XmlElement("details")]
            public string Details { get; set; }

            [XmlElement("Trace")]
            public string Trace { get; set; }
        }

    }
}
