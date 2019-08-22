using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    public class SolicitorDto
    {
        public int? SolicitorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Label { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberId { get; set; }
    }
}