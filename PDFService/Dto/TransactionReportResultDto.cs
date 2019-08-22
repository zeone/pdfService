using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class TransactionReportResultDto
    {
        public List<TransactionReportFamily> Families { get; set; }
        public List<int> CategoriesIDs { get; set; }
        public List<TransactionsReportList> Transactions { get; set; }
        public List<TransactionsReportList> UnassignedPayments { get; set; }
        public int TotalCount { get; set; }
    }
}