using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PDFService.Dto;

namespace PDFService
{

    [ServiceContract]
    public interface IPdfService
    {
        /// <summary>
        /// return byte array for contact report
        /// will execute all operations from database and do filtering operations
        /// after that will be create a pdf file
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        byte[] GetContactPdf(ContactReportFilterRequest request);

        /// <summary>
        /// return byte array for transaction report
        /// will execute all operations from database and do filtering operations
        /// after that will be create a pdf file 
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        byte[] GetTransactionPdf(TransactionReportFilterRequest request);


        /// <summary>
        /// Generate pdf document for contact report
        /// take only prepared data (without using db)
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        byte[] CreateContactReportPDf(ContactReportPdfOnlyRequest request);

        /// <summary>
        /// Generate pdf document for transaction report
        /// take only prepared data (without using db)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] CreateTransactionReportPDf(TransactionReportPdfOnlyRequest request);

    }



}
