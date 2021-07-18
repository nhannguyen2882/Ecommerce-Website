using System;
using System.ComponentModel.DataAnnotations;

namespace EcomWeb.DataAccessor.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        //public Guid? CreatorId { get; set; }

        public bool Pubished { get; set; }
    }
}
