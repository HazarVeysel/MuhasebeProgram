using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class CustomerPaymentTable
    {
        public int CustomerPaymenId { get; set; }
        public int CustomerId { get; set; }
        public int CustomerInvoiceId { get; set; }
        public int UserId { get; set; }
        public int InvoiceNo { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double RemainingBalance { get; set; }

        public virtual CustomerTable Customer { get; set; }
        public virtual CustomerInvoiceTable CustomerInvoice { get; set; }
        public virtual UsersTable User { get; set; }
    }
}
