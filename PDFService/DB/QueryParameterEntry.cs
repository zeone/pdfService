using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PDFService.DB
{
    internal class QueryParameterEntry
    {
        /// <summary>
        /// Database parameter 
        /// </summary>
        public SqlParameter Parameter { get; set; }

        /// <summary>
        /// Parameter configuration
        /// </summary>
        public QueryParameterConfig Config { get; set; }
    }
}