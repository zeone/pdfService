﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    public class ClassDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ClassId { get; set; }

    
        public string Class { get; set; }

  
        public bool IsActive { get; set; }

        [XmlElement("Subclass")]
        public SubclassDto[] Subclasses { get; set; }
    }
}