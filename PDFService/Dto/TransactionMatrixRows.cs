using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class TransactionMatrixRows
    {
        public string Name { get; set; }
        public string TotalName { get; set; }
        public FamilyDetails FamilyDetails { get; set; }
        public List<decimal> Amounts { get; set; }
        public List<TransactioMatrixSubDetails> SubDetails { get; set; }

    }
}