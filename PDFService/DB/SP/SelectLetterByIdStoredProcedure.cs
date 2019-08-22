using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.DB.SP
{
    public class SelectLetterByIdStoredProcedure : StoredProcedureReturningSelectResultQuery<LetterDto>
    {
        public SelectLetterByIdStoredProcedure(IQueryProvider provider, PerSchemaSqlDbContext dbContext)
            : base(provider, dbContext)
        {
        }

        protected override string GetCommandText()
        {
            return "dbo.SelectLetterById";
        }

        public short LetterId
        {
            get { return GetParameter<short>("@LetterId"); }
            set
            {
                SetParameter(paramName: "@LetterId",
                    paramValue: value,
                    sqlDbType: SqlDbType.SmallInt,
                    isNullable: false,
                    direction: ParameterDirection.Input);
            }
        }
    }
}