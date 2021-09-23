using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class SupplierTable
    {
        public SupplierTable()
        {
            SupplierInvoiceTable = new HashSet<SupplierInvoiceTable>();
            SupplierPaymentTable = new HashSet<SupplierPaymentTable>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Contactno { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SupplierInvoiceTable> SupplierInvoiceTable { get; set; }
        public virtual ICollection<SupplierPaymentTable> SupplierPaymentTable { get; set; }
    }
}
