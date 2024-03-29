﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Ninject.Modules;

namespace PDFService.DB.Injections
{
    public sealed class DalNInjectModule : NinjectModule
    {
        public override void Load()
        {

        }
    }

    public sealed class QueriesNInjectModule : NinjectModule
    {
        public override void Load()
        {
            var queryTypes = (from queryType in Assembly.GetExecutingAssembly().GetTypes()
                where typeof(BaseQuery).IsAssignableFrom(queryType) && !queryType.IsAbstract
                select queryType).ToList();

            // bind each found Query type to itself
            // ALWAYS create a new Query object
            queryTypes.ForEach(queryType =>
                Bind(queryType)
                    .ToSelf()
                    .InTransientScope());
        }
    }
}