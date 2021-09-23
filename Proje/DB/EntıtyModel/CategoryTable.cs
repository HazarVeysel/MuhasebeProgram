using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class CategoryTable
    {
        public CategoryTable()
        {
            StockTable = new HashSet<StockTable>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<StockTable> StockTable { get; set; }
    }
}
