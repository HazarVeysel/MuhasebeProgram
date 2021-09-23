using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class StockTable
    {
        public StockTable()
        {
            CustomerInvoiceDetailsTable = new HashSet<CustomerInvoiceDetailsTable>();
            SupplierInvoiceDetailsTable = new HashSet<SupplierInvoiceDetailsTable>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SaleUnitPrice { get; set; }
        public double CurrentPurchaseUnitPrice { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? MfturDate { get; set; }
        public int StockTrasholdQty { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual CategoryTable Category { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<CustomerInvoiceDetailsTable> CustomerInvoiceDetailsTable { get; set; }
        public virtual ICollection<SupplierInvoiceDetailsTable> SupplierInvoiceDetailsTable { get; set; }
    }
}
