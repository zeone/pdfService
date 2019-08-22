using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PDFService.DB.SP;
using PDFService.Dto;
using PDFService.Enums;
using PDFService.Helpers;
using IQueryProvider = PDFService.DB.IQueryProvider;

namespace PDFService.Services.Implementation
{
    public class MailingService : BaseService, IMailingService
    {
        private string _schema;

        public MailingService(IQueryProvider queryProvider, string schema) : base(queryProvider)
        {
            _schema = schema;
        }

        public IEnumerable<MailingDto> GetAllMailings()
        {
            return GetMailings(null);
        }
        
        private IEnumerable<MailingDto> GetMailings(int? mailigID)
        {
            var selectMailingsSp = QueryProvider.CreateQuery<SelectMailingsStoredProcedure>(_schema);
            selectMailingsSp.MailingID = mailigID;
            var res = selectMailingsSp.Execute();
            return !res.HasNoDataRows ? res.ResultToArray<MailingDto>() : ArrayUtils.Empty<MailingDto>();
        }
        
    }
}