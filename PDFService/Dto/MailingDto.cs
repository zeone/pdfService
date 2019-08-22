using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PDFService.Dto
{
    public class MailingDto
    {
        public int? MailingId { get; set; }

        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPieces { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Cost { get; set; }
    }
}