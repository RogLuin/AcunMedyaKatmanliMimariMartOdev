using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryTechnologyRepository : ITechnologyRepository
    {
        private List<Technology> _technologiesRepository;

        public InMemoryTechnologyRepository()
        {
            _technologiesRepository = new List<Technology>
            {
                new Technology(1,"ASP.NET Core","C#"),
                new Technology(2,"ASP.NET Core MVC","C#"),
                new Technology(3,"ASP.NET Core Web API","C#"),
            };
        }





        public void Add(Technology technology)
        {
            _technologiesRepository.Add(technology);
        }

        public void Delete(int id)
        {
            var technologyToDelete = _technologiesRepository.SingleOrDefault(p => p.Id == id);
            if(technologyToDelete != null)
            {
                _technologiesRepository.Remove(technologyToDelete);
            }
            else
            {
                throw new Exception("Technology not found");
            }
        }

        public List<Technology> GetAllTechnologies()
        {
            return _technologiesRepository;
        }

        public List<Technology> GettById(int id)
        {

            return _technologiesRepository.FindAll(p => p.Id == id);

        }

        public void Update(int id, Technology technology)
        {
            var technologyToUpdate = _technologiesRepository.SingleOrDefault(p => p.Id == id);
            if (technologyToUpdate != null) 
            {
                technologyToUpdate.TechnologyName = technology.TechnologyName;
                technologyToUpdate.ProgrammingLanguage = technology.ProgrammingLanguage;
            }
            else
            {
                throw new Exception("Technology not found");
            }
        }
    }
}
