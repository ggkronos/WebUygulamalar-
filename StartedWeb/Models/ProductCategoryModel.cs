using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartedWeb.Models
{
    public class ProductCategoryModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

    }
}