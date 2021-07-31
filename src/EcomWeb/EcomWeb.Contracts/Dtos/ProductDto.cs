using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal? Price { get; set; }
        public Guid? CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Published { get; set; }

        //public string ImageURL { get; set; }
    }

  
}
