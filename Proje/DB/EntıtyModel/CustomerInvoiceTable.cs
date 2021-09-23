using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class CustomerInvoiceTable
    {
        public CustomerInvoiceTable()
        {
            CustomerInvoiceDetailsTable = new HashSet<CustomerInvoiceDetailsTable>();
            CustomerPaymentTable = new HashSet<CustomerPaymentTable>();
        }

        public int CustomerInvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string InvoiceNo { get; set; }
        public string Title { get; set; }
        public double TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }

        public virtual CustomerTable Customer { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<CustomerInvoiceDetailsTable> CustomerInvoiceDetailsTable { get; set; }
        public virtual ICollection<CustomerPaymentTable> CustomerPaymentTable { get; set; }
    }
}
