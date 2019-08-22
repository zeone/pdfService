using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PDFService.Dto
{
    [XmlRoot("Item")]
    public class ItemDto
    {
        [XmlElement("ItemID")]
        public int? ItemId { get; set; }

        [XmlElement("SubcategoryId")]
        public int SubcategoryId { get; set; }

        [XmlElement("ItemName")]
        public string ItemName { get; set; }

        [XmlElement("Amount")]
        public decimal Amount { get; set; }

        [XmlElement("IsActive")]
        public bool IsActive { get; set; }
    }
}