using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    [DataContract]
    public class SolicitorDto
    {
        [DataMember]
        public int? SolicitorId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Label { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberId { get; set; }
    }
}