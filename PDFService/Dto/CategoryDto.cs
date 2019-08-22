using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    public class CategoryDto
    {
        public int? CategoryId { get; set; }

        public string Category { get; set; }

        public bool IsActive { get; set; }

        public bool IsReceipt { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultLetterId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultDepartmentId { get; set; }

        [XmlElement("Subcategory")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SubcategoryDto[] Subcategories { get; set; }
    }
}