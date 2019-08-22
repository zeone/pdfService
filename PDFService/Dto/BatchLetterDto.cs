using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class BatchLetterDto
    {
        public int FamilyId { get; set; }

        public int MemberId { get; set; }

        public int TransactionId { get; set; }

        public string LetterText { get; set; }

        public int LetterId { get; set; }
    }
}