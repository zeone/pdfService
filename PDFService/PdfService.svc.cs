using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ninject;
using Ninject.Parameters;
using PDFService.DB.SP;
using PDFService.Dto;
using PDFService.Helpers;
using PDFService.Services;

namespace PDFService
{

    public class PdfService : IPdfService
    {
        static IReportService _service;


        public byte[] GetContactPdf(ContactReportFilterRequest request)
        {
            _service = NinjectBulder.Container.Get<IReportService>(new ConstructorArgument("schema", request.Schema));

            return _service.GetPdf(request.ReportDto, TranslateHelper.GetTranslation, request.Country);
        }

        public byte[] GetTransactionPdf(TransactionReportFilterRequest request)
        {
            var contactPdfService = NinjectBulder.Container.Get<IReportService>(new ConstructorArgument("schema", request.Schema));

            return contactPdfService.GetPdf(request.Filter, TranslateHelper.GetTranslation);

        }

        public byte[] CreateContactReportPDf(ContactReportPdfOnlyRequest request)
        {
            var contactPdfService = NinjectBulder.Container.Get<IContactReportPdfService>(new ConstructorArgument("schema", request.Schema));

            return contactPdfService.CreateDocument(request.ReportDto, request.Contacts, request.CountryName,
                TranslateHelper.GetTranslation);
        }

        public byte[] CreateTransactionReportPDf(TransactionReportPdfOnlyRequest request)
        {
            var transPdfService = NinjectBulder.Container.Get<ITransactionReportPdfService>(new ConstructorArgument("schema", request.Schema));
            transPdfService.InitializeCollections(TranslateHelper.GetTranslation, request.PaymentMethods, request.Solicitors, request.Mailings, request.Departments, request.CategoryTree);

            return transPdfService.CreateDocument(request.Filter, request.Grouped, request.TransactionCount);
        }
    }
}
