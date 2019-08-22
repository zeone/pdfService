using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;
using PDFService.Enums;

namespace PDFService.Dto
{
    [DataContract]
    public class ReportDto
    {
        [DataMember]
        FilterTransactionReport _filter;
        [DataMember]
        public int ReportId { get; set; }
        [DataMember]
        public ReportTypes ReportType { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime? Created { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        [JsonIgnore]
        public string Filter { get; set; }
        [DataMember]
        public ExportReportPreference AdditionalPreferences { get; set; }

        [DataMember]
        public FilterTransactionReport Criteria
        {
            get
            {
                if (_filter == null && Filter != null)
                    _filter = JsonConvert.DeserializeObject<FilterTransactionReport>(Filter);
                return _filter;
                //return Filter == null ? new FilterContactReport() : JsonConvert.DeserializeObject<FilterContactReport>(Filter);
            }
            set
            {
                _filter = value;

                if (_filter != null) Filter = JsonConvert.SerializeObject(value);
            }
        }

        [DataContract]
        public class ExportReportPreference
        {
            [DataMember]
            public string ExportType { get; set; }
            [DataMember]
            public string CustomAddress { get; set; }
            [DataMember]
            public int? FamilyAddressId { get; set; }
            [DataMember]
            public int? FamilyId { get; set; }
        }
    }
}