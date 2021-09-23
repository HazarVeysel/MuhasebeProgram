using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class AccountSubControlTable
    {
        public AccountSubControlTable()
        {
            TransactionTable = new HashSet<TransactionTable>();
        }

        public int AccountSubControlD { get; set; }
        public int AccountHeadId { get; set; }
        public int AccountControlId { get; set; }
        public int UserId { get; set; }
        public string AccountSubControlName { get; set; }

        public virtual AccountControlTable AccountControl { get; set; }
        public virtual AccountHeadTable AccountHead { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<TransactionTable> TransactionTable { get; set; }
    }
}
