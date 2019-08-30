using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class ServiceResponse
    {
        [DataMember]
        public int ReportQId { get; set; }
        [DataMember]
        public string Schema { get; set; }
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public byte[] PdfByteArr { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string StackTrace { get; set; }
    }
}