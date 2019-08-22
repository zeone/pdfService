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
    public class PaymentMethodService : BaseService, IPaymentMethodService
    {
        private string _schema;

        public PaymentMethodService(IQueryProvider queryProvider, string schema) : base(queryProvider)
        {
            _schema = schema;
        }

       public IEnumerable<PaymentMethodDto> GetAllPaymentMethods()
        {
            return GetPaymentMethods(null);
        }

        private IEnumerable<PaymentMethodDto> GetPaymentMethods(int? paymentMethodId)
        {
            var selectPaymentMethodsSp = QueryProvider.CreateQuery<SelectPaymentMethodStoredProcedure>(_schema);
            selectPaymentMethodsSp.PaymentMethodID = paymentMethodId;
            var result = selectPaymentMethodsSp.Execute();
            var res = result.ResultToArray<PaymentMethodDto>();
            return result.DataRows != null ? result.ResultToArray<PaymentMethodDto>() : null;
        }

       
    }
}