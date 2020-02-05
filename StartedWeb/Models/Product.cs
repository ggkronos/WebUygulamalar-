using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartedWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductInfo { get; set; }
        public int StockAmount { get; set; }
        public bool IsSale { get; set; }
        
    }
}