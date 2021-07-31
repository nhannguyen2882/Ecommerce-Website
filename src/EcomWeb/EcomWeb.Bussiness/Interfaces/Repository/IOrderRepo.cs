using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWeb.Bussiness.Interfaces.Repository
{
    public interface IOrderRepo<T> : IBaseRepository<T> where T:class
    {

    }
}
