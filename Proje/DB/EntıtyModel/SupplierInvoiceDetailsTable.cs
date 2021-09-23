using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class SupplierInvoiceDetailsTable
    {
        public int SupplierInvoiceDetailId { get; set; }
        public int SupplierInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int PurchaseQty { get; set; }
        public double PurchaseUnitPrice { get; set; }

        public virtual StockTable Product { get; set; }
        public virtual SupplierInvoiceTable SupplierInvoice { get; set; }
    }
}
