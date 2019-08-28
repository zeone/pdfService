using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    [DataContract]
    public class PaymentMethodDto
    {
        [DataMember]
        [JsonProperty(PropertyName = "PaymentMethodId")]
        public int PaymentMethodId { get; set; }

        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public byte MethodTypeId { get; set; }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string MethodType { get; set; }
    }
}