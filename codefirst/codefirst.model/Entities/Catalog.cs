using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codefirst.model.Entities
{
    public class Catalog
    {
        public int CatalogID { get; set; }
        public string CatalogName { get; set; }
        public string Note { get; set; }
        public bool Action { get; set; }
    }
}
