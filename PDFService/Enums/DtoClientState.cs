using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDFService.Enums
{
    /// <summary>
    /// State of the DTO model on the client side
    /// </summary>
    public enum DtoClientState
    {
        Unchanged = 0,
        Changed,
        New,
        Deleted
    }
}