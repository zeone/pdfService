using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Dto
{
    public class QueueObject
    {
        public QueueObject(object filter, Func<object, byte[]> execution)
        {
            FilterDataObj = filter;
            Executor = execution;
        }

        public object FilterDataObj { get; set; }
        public Func<object, byte[]> Executor { get; set; }
    }
}