using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.DB.SP
{
    public class SelectSolicitorsStoredProcedure : StoredProcedureReturningSelectResultQuery<SolicitorDto>
    {
        public SelectSolicitorsStoredProcedure(IQueryProvider provider, PerSchemaSqlDbContext dbContext) : base(provider, dbContext) { }

        protected override string GetCommandText()
        {
            return "dbo.SelectSolicitors";
        }

        public int? SolicitorID
        {
            get { return GetParameter<int?>("@SolicitorID"); }
            set
            {
                SetParameter(paramName: "@SolicitorID",
                    paramValue: value,
                    sqlDbType: SqlDbType.Int,
                    isNullable: true,
                    direction: ParameterDirection.Input);
            }
        }
    }
}