using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFService.Services
{
    public interface IHebrewDateService
    {
        JewishDate ConvertToHebrewDate(int day, int month, int year, bool afterDark);
    }
}
