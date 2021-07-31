using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class OrderDto
    {
        public Guid? ShoppingCartID { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

    }
}
