using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITechnologyRepository
    {
     void Add(Technology technology);

     void Delete(int id);
      
    void Update(int id, Technology technology);

     List<Technology> GetAllTechnologies();

     List<Technology> GettById(int id);
    }
}
