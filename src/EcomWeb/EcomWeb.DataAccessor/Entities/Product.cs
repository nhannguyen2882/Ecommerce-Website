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

        [Required]
        public Guid? CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }
    }
}
