using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class UsersTable
    {
        public UsersTable()
        {
            AccountControlTable = new HashSet<AccountControlTable>();
            AccountHeadTable = new HashSet<AccountHeadTable>();
            AccountSubControlTable = new HashSet<AccountSubControlTable>();
            CustomerInvoiceTable = new HashSet<CustomerInvoiceTable>();
            CustomerPaymentTable = new HashSet<CustomerPaymentTable>();
            StockTable = new HashSet<StockTable>();
            SupplierInvoiceTable = new HashSet<SupplierInvoiceTable>();
            SupplierPaymentTable = new HashSet<SupplierPaymentTable>();
            TransactionTable = new HashSet<TransactionTable>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual UserTypesTable UserType { get; set; }
        public virtual ICollection<AccountControlTable> AccountControlTable { get; set; }
        public virtual ICollection<AccountHeadTable> AccountHeadTable { get; set; }
        public virtual ICollection<AccountSubControlTable> AccountSubControlTable { get; set; }
        public virtual ICollection<CustomerInvoiceTable> CustomerInvoiceTable { get; set; }
        public virtual ICollection<CustomerPaymentTable> CustomerPaymentTable { get; set; }
        public virtual ICollection<StockTable> StockTable { get; set; }
        public virtual ICollection<SupplierInvoiceTable> SupplierInvoiceTable { get; set; }
        public virtual ICollection<SupplierPaymentTable> SupplierPaymentTable { get; set; }
        public virtual ICollection<TransactionTable> TransactionTable { get; set; }
    }
}
