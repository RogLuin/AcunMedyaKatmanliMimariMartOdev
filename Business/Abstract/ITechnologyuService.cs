using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITechnologyuService
    {
        void Add(Technology technology);
        List<Technology> GetListTechnologies();
    }
}
