﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PDFService.Dto
{
    [DataContract]
    public class TransactionReportPdfOnlyRequest : BaseFilterRequest
    {
        [DataMember]
        public TransactionGrouped Grouped { get; set; }

        [DataMember]
        public int TransactionCount { get; set; }

        #region Collections
        [DataMember]
        public IEnumerable<PaymentMethodDto> PaymentMethods { get; set; }

        [DataMember]
        public IEnumerable<SolicitorDto> Solicitors { get; set; }

        [DataMember]
        public IEnumerable<MailingDto> Mailings { get; set; }

        [DataMember]
        public IEnumerable<DepartmentDto> Departments { get; set; }

        [DataMember]
        public IEnumerable<CategoryDto> CategoryTree { get; set; }


        #endregion
    }
}