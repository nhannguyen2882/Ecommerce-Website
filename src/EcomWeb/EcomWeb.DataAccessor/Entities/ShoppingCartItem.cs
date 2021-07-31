using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    public class ShoppingCartItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal? Price { get; set; }

        public Product Product { get; set; }
        public Guid? ProductID { get; set; }
    }
}
