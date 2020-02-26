using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Models
{
    public class InvoiceModel
    {
        //True=request False=Donate
        public int InvoiceType { get; set; }

        public string InvoiceItemName { get; set; }

        public int InvoiceItemCount { get; set; }

        public int InvoiceID { get; set; }

        public string RequestUser { get; set; }

        public string ApproveUser { get; set; }

        public int InvoiceStatus { get; set; }

        public SelectList InvoiceOptions { get; set; }

    }
}
