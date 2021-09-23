using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class SupplierPaymentTable
    {
        public int SupplierPaymentId { get; set; }
        public int SupplierId { get; set; }
        public int SupplierInvoiceId { get; set; }
        public int UserId { get; set; }
        public string InvoiceNo { get; set; }
        public double TotalAmount { get; set; }
        public double PaymentAmount { get; set; }
        public double RemainingBalance { get; set; }

        public virtual SupplierTable Supplier { get; set; }
        public virtual SupplierInvoiceTable SupplierInvoice { get; set; }
        public virtual UsersTable User { get; set; }
    }
}
