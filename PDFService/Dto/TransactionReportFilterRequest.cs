using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class TransactionReportFilterRequest
    {
        /// <summary>
        /// filter criteria
        /// </summary>
        [DataMember]
        public FilterTransactionReport Filter { get; set; }

        /// <summary>
        /// db schema name
        /// </summary>
        [DataMember]
        public string Schema { get; set; }
    }
}