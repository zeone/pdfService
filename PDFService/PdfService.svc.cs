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
        static IReportService _reportService;
        static IExecutionService _executionService = NinjectBulder.Container.Get<IExecutionService>();

        public void GetContactPdf(ContactReportFilterRequest request)
        {
            _reportService = NinjectBulder.Container.Get<IReportService>(new ConstructorArgument("schema", request.Schema));

            _executionService.AddTask($"{request.ReportQId}_{request.Schema}",
                (object)request,  _reportService.GetContactPdf);
        }

        public void GetTransactionPdf(TransactionReportFilterRequest request)
        {
            var contactPdfService = NinjectBulder.Container.Get<IReportService>(new ConstructorArgument("schema", request.Schema));
            request.ReportDto.Country = request.CountryName;
            _executionService.AddTask($"{request.ReportQId}_{request.Schema}",
                (object)request, _reportService.GetTransactionPdf);

        }

        public void CreateContactReportPDf(ContactReportPdfOnlyRequest request)
        {
            var contactPdfService = NinjectBulder.Container.Get<IContactReportPdfService>(new ConstructorArgument("schema", request.Schema));
            request.ReportDto.Country = request.CountryName;
            var pdfDoc = new PdfDocumentDto
            {
                ReportDto = request.ReportDto,
                Contacts = request.Contacts
            };
            _executionService.AddTask($"{request.ReportQId}_{request.Schema}",
                (object)request, contactPdfService.CreateDocument);
            
        }

        public void CreateTransactionReportPDf(TransactionReportPdfOnlyRequest request)
        {
            var transPdfService = NinjectBulder.Container.Get<ITransactionReportPdfService>(new ConstructorArgument("schema", request.Schema));
            transPdfService.InitializeCollections(TranslateHelper.GetTranslation, request.PaymentMethods, request.Solicitors, request.Mailings, request.Departments, request.CategoryTree);
            request.ReportDto.Country = request.CountryName;
            request.ReportDto.Country = request.CountryName;
            var pdfDoc = new PdfDocumentDto
            {
                Filter = request.Filter,
                Grouped = request.Grouped,
                CountTrans = request.TransactionCount
            };
            _executionService.AddTask($"{request.ReportQId}_{request.Schema}",
                (object)request, transPdfService.CreateDocument);
        }
    }
}
