using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Contracts.Dtos
{
    public class FeedbackDto
    {
        public Guid? ID { get; set; }
        public int Star { get; set; }

        public string Comment { get; set; }

    }
}
