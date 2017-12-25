using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codefirst.model.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CatalogID { get; set; }
        public string ProductPrice { get; set; }
        public string Note { get; set; }
        public bool Action { get; set; }
    }
}
