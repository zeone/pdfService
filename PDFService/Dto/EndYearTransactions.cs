﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class EndYearTransactions
    {
        public string Date { get; set; }
        public DateTime DonationDateTime { get; set; }
        public string Method { get; set; }
        public string Number { get; set; }
        public string Amount { get; set; }
        public int? Receipt { get; set; }
        public string Purpose { get; set; }
    }
}