using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    class Category : BaseEntity
    {
        public string Name { get; set; }
        
        public string Desc { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
