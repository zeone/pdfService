using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    public class SubclassDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SubclassId")]
        public int SubclassId { get; set; }

        [XmlElement("ClassId")]
        public int ClassId { get; set; }

        [XmlElement("Subclass")]
        public string Subclass { get; set; }

        [XmlElement("IsActive")]
        public bool IsActive { get; set; }
    }
}