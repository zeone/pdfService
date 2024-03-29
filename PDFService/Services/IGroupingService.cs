﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFService.Dto;
using PDFService.Enums;

namespace PDFService.Services
{
    public interface IGroupingService
    {
 
        /// <summary>
        /// List of Category and Subcategory records belongigng
        /// to Categories and Subcategories
        /// </summary>
        /// <returns></returns>
        CategoryDto[] GetCategoryTree();
       
    }
}
