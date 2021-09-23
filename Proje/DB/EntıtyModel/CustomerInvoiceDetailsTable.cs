using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class CustomerInvoiceDetailsTable
    {
        public int CustomerInvoiceDetailId { get; set; }
        public int CustomerInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int SaleQty { get; set; }
        public int SaleUnitPrice { get; set; }

        public virtual CustomerInvoiceTable CustomerInvoice { get; set; }
        public virtual StockTable Product { get; set; }
    }
}
