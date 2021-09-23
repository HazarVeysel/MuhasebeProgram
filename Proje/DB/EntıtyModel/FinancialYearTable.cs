using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class FinancialYearTable
    {
        public FinancialYearTable()
        {
            TransactionTable = new HashSet<TransactionTable>();
        }

        public int FinancialYearId { get; set; }
        public string FinancialYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TransactionTable> TransactionTable { get; set; }
    }
}
