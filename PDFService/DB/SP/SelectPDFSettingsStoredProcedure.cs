using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.DB.SP
{
    public class SelectPDFSettingsStoredProcedure : StoredProcedureReturningSelectResultQuery<PdfSettingDto>
    {
        public SelectPDFSettingsStoredProcedure(IQueryProvider provider, PerSchemaSqlDbContext dbContext) : base(provider, dbContext)
        {
        }

        protected override string GetCommandText()
        {
            return "dbo.SelectPDFSettings";
        }

        public int? PDFSettingID
        {
            get { return GetParameter<int?>("@PDFSettingID"); }
            set
            {
                SetParameter(paramName: "@PDFSettingID",
                    paramValue: value,
                    sqlDbType: SqlDbType.Int,
                    isNullable: true,
                    direction: ParameterDirection.Input);
            }
        }
    }
}