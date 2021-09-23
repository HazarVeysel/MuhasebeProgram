using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class SupplierInvoiceTable
    {
        public SupplierInvoiceTable()
        {
            SupplierInvoiceDetailsTable = new HashSet<SupplierInvoiceDetailsTable>();
            SupplierPaymentTable = new HashSet<SupplierPaymentTable>();
        }

        public int SupplierInvoiceId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public string InvoiceNo { get; set; }
        public string Title { get; set; }
        public double TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }

        public virtual SupplierTable Supplier { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<SupplierInvoiceDetailsTable> SupplierInvoiceDetailsTable { get; set; }
        public virtual ICollection<SupplierPaymentTable> SupplierPaymentTable { get; set; }
    }
}
