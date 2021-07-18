using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Desc { get; set; }

        public decimal Price { get; set; }

        public decimal? Cost { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
