using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class ContactReportPdfOnlyRequest
    {
        /// <summary>
        /// prepared filters
        /// </summary>
        [DataMember]
        public ReportDto ReportDto { get; set; }
        /// <summary>
        /// list of prepared contact info
        /// </summary>
        [DataMember]
        public List<ContactReportResultDto> Contacts { get; set; }
        /// <summary>
        /// organization country name
        /// </summary>
        [DataMember]
        public string CountryName { get; set; }
        /// <summary>
        /// delegate for translation
        /// </summary>
        [DataMember]
        public Func<string, string> TransFunc { get; set; }

        /// <summary>
        /// organization schema name
        /// </summary>
        public string Schema { get; set; }
    }
}