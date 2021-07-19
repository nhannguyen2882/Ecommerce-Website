using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.DataAccessor.Entities
{
    public class Image
    {
        public Guid Id { set; get; }

        public string Url { set; get; }

        public Guid? ProductId { get; set; }
    }
}
