using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PDFService.Dto;

namespace PDFService.Services
{
    public interface ITransactionReportPdfService
    {
        void InitializeCollections(Func<string, string> transFunc, IEnumerable<PaymentMethodDto> paymentMethods,
            IEnumerable<SolicitorDto> solicitors, IEnumerable<MailingDto> mailings,
            IEnumerable<DepartmentDto> departments, IEnumerable<CategoryDto> categoryTree);

        byte[] CreateDocument(object docObj);
    }
}