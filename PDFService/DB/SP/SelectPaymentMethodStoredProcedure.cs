﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.DB.SP
{
    public class SelectPaymentMethodStoredProcedure : StoredProcedureReturningSelectResultQuery<PaymentMethodDto>
    {
        public SelectPaymentMethodStoredProcedure(IQueryProvider provider, PerSchemaSqlDbContext dbContext) : base(provider, dbContext) { }

        protected override string GetCommandText()
        {
            return "dbo.SelectPaymentMethods";
        }

        public int? PaymentMethodID
        {
            get { return GetParameter<int?>("@PaymentMethodID"); }
            set
            {
                SetParameter(paramName: "@PaymentMethodID",
                    paramValue: value,
                    sqlDbType: SqlDbType.Int,
                    isNullable: true,
                    direction: ParameterDirection.Input);
            }
        }
    }
}