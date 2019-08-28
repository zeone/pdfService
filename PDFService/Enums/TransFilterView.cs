using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Enums
{
    [DataContract]
    public enum TransFilterView
    {
        [EnumMember]
        Details = 0,
        [EnumMember]
        Total = 1
    }
}