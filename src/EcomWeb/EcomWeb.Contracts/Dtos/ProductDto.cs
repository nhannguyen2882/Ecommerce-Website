using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class ProductDto
    {
        [Required]
        public Guid? Id { get; set; }

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
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Published { get; set; }

        //public string ImageURL { get; set; }
    }

  
}
