using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    public class Feedback : BaseEntity
    {
        [Required]
        public int Star { get; set; }

        [StringLength(maximumLength: 200)]
        public string Comment { get; set; }

        [Required]
        public Guid? ProductId { get; set; }

        [Required]
        public Product Product { get; set; }

    }
}
