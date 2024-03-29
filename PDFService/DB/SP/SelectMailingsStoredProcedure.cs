﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.DB.SP
{
    public class SelectMailingsStoredProcedure : StoredProcedureReturningSelectResultQuery<MailingDto>
    {
        public SelectMailingsStoredProcedure(IQueryProvider provider, PerSchemaSqlDbContext dbContext) : base(provider, dbContext) { }

        protected override string GetCommandText()
        {
            return "dbo.SelectMailings";
        }

        public int? MailingID
        {
            get { return GetParameter<int?>("@MailingID"); }
            set
            {
                SetParameter(paramName: "@MailingID",
                    paramValue: value,
                    sqlDbType: SqlDbType.Int,
                    isNullable: true,
                    direction: ParameterDirection.Input);
            }
        }
    }
}