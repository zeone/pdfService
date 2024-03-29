﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace PDFService.Dto
{
    [DataContract]
    [XmlRoot("Item")]
    public class ItemDto
    {
        [DataMember]
        [XmlElement("ItemID")]
        public int? ItemId { get; set; }

        [DataMember]
        [XmlElement("SubcategoryId")]
        public int SubcategoryId { get; set; }

        [DataMember]
        [XmlElement("ItemName")]
        public string ItemName { get; set; }

        [DataMember]
        [XmlElement("Amount")]
        public decimal Amount { get; set; }

        [DataMember]
        [XmlElement("IsActive")]
        public bool IsActive { get; set; }
    }
}