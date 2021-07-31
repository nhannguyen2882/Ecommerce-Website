using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class ShoppingCartItemDto
    {
        public int Quantity { get; set; }
        public decimal? Price { get; set; }
        public Guid? ProductID { get; set; }
    }
}
