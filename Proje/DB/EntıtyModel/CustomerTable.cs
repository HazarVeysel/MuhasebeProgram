using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class CustomerTable
    {
        public CustomerTable()
        {
            CustomerInvoiceTable = new HashSet<CustomerInvoiceTable>();
            CustomerPaymentTable = new HashSet<CustomerPaymentTable>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public string Area { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CustomerInvoiceTable> CustomerInvoiceTable { get; set; }
        public virtual ICollection<CustomerPaymentTable> CustomerPaymentTable { get; set; }
    }
}
