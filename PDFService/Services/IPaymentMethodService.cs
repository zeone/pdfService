using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PDFService.Dto;
using PDFService.Enums;

namespace PDFService.Services
{
    public interface IPaymentMethodService : IAppService
    {

        /// <summary>
        /// Gets all payment methods from database
        /// </summary>
        /// <returns></returns>
        IEnumerable<PaymentMethodDto> GetAllPaymentMethods();
    }
}