using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    public class Order : BaseEntity
    {
        public Guid? ShoppingCartID { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public ICollection<ShoppingCartItem> Items { get; set; }
    }
}
