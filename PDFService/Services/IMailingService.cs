﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFService.Dto;
using PDFService.Enums;

namespace PDFService.Services
{
    public interface IMailingService : IAppService
    {
        /// <summary>
        /// Get al mailings fro the database
        /// </summary>
        /// <returns>List of <see cref="MailingDto"/> objects</returns>
        IEnumerable<MailingDto> GetAllMailings();
    }
}
