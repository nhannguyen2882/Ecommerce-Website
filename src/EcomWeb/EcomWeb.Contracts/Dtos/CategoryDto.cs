using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class CategoryDto
    {
        public Guid? ID { get; set; }        
        public string Name { get; set; }

        public string Desc { get; set; }

    }
}
