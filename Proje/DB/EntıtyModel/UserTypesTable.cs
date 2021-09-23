using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class UserTypesTable
    {
        public UserTypesTable()
        {
            UsersTable = new HashSet<UsersTable>();
        }

        public int UserTypeId { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<UsersTable> UsersTable { get; set; }
    }
}
