using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PDFService.Helpers;

namespace PDFService.DB.Builder
{
    public sealed class ScalarValueBuilder<TScalar> : BaseModelBuilder<TScalar>
    {

        protected override TScalar BuildSingleModel(IDataReader dbDataReader,
            System.Reflection.PropertyInfo[] properties)
        {
            object scalarValue = dbDataReader.GetValue(0);

            if (typeof(TScalar).Equals(typeof(StringAdapter)))
            {
                // in case we're building the StringAdapter model
                scalarValue = new StringAdapter(
                    ((scalarValue != null) && !DBNull.Value.Equals(scalarValue))
                        ? scalarValue.ToString()
                        : (string) null
                );
            }

            return (TScalar) scalarValue;
        }
    }
}