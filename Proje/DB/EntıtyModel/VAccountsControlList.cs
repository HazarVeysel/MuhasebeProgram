using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class VAccountsControlList
    {
        public int Id { get; set; }
        public int AccountHeadId { get; set; }
        public string AccountHead { get; set; }
        public string AccountControl { get; set; }
        public string User { get; set; }
    }
}
