using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Desc { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
