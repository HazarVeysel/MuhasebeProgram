using System;
using System.Collections.Generic;

namespace DB.EntıtyModel
{
    public partial class VProductList
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
        public int Qty { get; set; }
        public double SaleUnitPrice { get; set; }
        public double PurchaseUnitPrice { get; set; }
        public DateTime? ManufacturDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int ThresholdQty { get; set; }
        public bool IsDeleted { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
    }
}
