using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PDFService.DB.SP;
using PDFService.Dto;
using PDFService.Enums;
using PDFService.Helpers;
using IQueryProvider = PDFService.DB.IQueryProvider;

namespace PDFService.Services.Implementation
{
    public class GroupingService : BaseService, IGroupingService
    {
        private string _schema;
        public GroupingService(IQueryProvider queryProvider, string schema) : base(queryProvider)
        {
            _schema = schema;
        }
        
        public CategoryDto[] GetCategoryTree()
        {
            var selectTransactionCategoryTreeSp =
                QueryProvider.CreateQuery<SelectTransactionCategoryTreeStoredProcedure>(_schema);

            var result = selectTransactionCategoryTreeSp.Execute();
            return result.ResultToArray<CategoryDto>();
        }
        
    }
}