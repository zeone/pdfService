using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class ContactReportFilterRequest
    {
        /// <summary>
        /// Filter criteria
        /// </summary>
        [DataMember]
        public ReportDto ReportDto { get; set; }

        /// <summary>
        /// db schema name
        /// </summary>
        [DataMember]
        public string Schema { get; set; }

        /// <summary>
        /// organization country
        /// </summary>
        [DataMember]
        public string Country { get; set; }
    }
}