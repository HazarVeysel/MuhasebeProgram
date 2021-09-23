using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class TransactionTable
    {
        public int TransactionId { get; set; }
        public int FinancialYearId { get; set; }
        public int AccountHeadId { get; set; }
        public int AccountControlId { get; set; }
        public int AccountSubControlId { get; set; }
        public string InvoiceNo { get; set; }
        public int UserId { get; set; }
        public double Credit { get; set; }
        public double Debit { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionTitle { get; set; }

        public virtual AccountControlTable AccountControl { get; set; }
        public virtual AccountHeadTable AccountHead { get; set; }
        public virtual AccountSubControlTable AccountSubControl { get; set; }
        public virtual FinancialYearTable FinancialYear { get; set; }
        public virtual UsersTable User { get; set; }
    }
}
