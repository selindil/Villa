using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Business.Abstract
{
    public interface ICounterService : IGenericService<Counter<int>>
    {
    }
}
