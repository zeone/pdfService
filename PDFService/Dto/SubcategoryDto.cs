using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    [XmlRoot("Subcategory")]
    public class SubcategoryDto
    {
        [XmlElement("CategoryId")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        [XmlElement("SubcategoryId")]
        public int? SubcategoryId { get; set; }

        [XmlElement("Subcategory")]
        public string Subcategory { get; set; }

        [XmlElement("IsActive")]
        public bool IsActive { get; set; }

        [XmlElement("DefaultLetterId")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultLetterId { get; set; }

        [XmlElement("Item", Type = typeof(ItemDto))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ItemDto[] Items { get; set; }

    }
}