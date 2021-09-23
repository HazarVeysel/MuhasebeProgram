using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class AccountControlTable
    {
        public AccountControlTable()
        {
            AccountSubControlTable = new HashSet<AccountSubControlTable>();
            TransactionTable = new HashSet<TransactionTable>();
        }

        public int AccountControlId { get; set; }
        public int UserId { get; set; }
        public int AccountHeadId { get; set; }
        public string AccountControlName { get; set; }

        public virtual AccountHeadTable AccountHead { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<AccountSubControlTable> AccountSubControlTable { get; set; }
        public virtual ICollection<TransactionTable> TransactionTable { get; set; }
    }
}
