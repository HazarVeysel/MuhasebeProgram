using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class AccountHeadTable
    {
        public AccountHeadTable()
        {
            AccountControlTable = new HashSet<AccountControlTable>();
            AccountSubControlTable = new HashSet<AccountSubControlTable>();
            TransactionTable = new HashSet<TransactionTable>();
        }

        public int AccountHeadId { get; set; }
        public int UserId { get; set; }
        public string AccountHeadName { get; set; }

        public virtual UsersTable User { get; set; }
        public virtual ICollection<AccountControlTable> AccountControlTable { get; set; }
        public virtual ICollection<AccountSubControlTable> AccountSubControlTable { get; set; }
        public virtual ICollection<TransactionTable> TransactionTable { get; set; }
    }
}
