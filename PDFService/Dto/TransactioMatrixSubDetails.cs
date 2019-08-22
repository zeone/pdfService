using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class TransactioMatrixSubDetails
    {
        public string Name { get; set; }
        public List<decimal> Amounts { get; set; }
    }
}