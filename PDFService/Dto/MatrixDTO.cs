using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class MatrixDTO : TransactionGrouped
    {
        public List<TransactionMatrixColumn> Columns { get; set; }
        public List<TransactionMatrixRows> Rows { get; set; }
    }
}