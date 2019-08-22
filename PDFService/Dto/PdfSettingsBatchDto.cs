using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class PdfSettingsBatchDto
    {

        public PdfSettingDto Settings { get; set; }
        public string CountryInSettings { get; set; }
        public LetterFieldsDto Fields { get; set; }
        public int LetterTypeId { get; set; }
    }
}