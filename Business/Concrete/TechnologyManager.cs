using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TechnologyManager : ITechnologyuService
    {
        private ITechnologyRepository _technologyRepository;

        public TechnologyManager(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        public void Add(Technology technology)
        {
           _technologyRepository.Add(technology);
        }

        public List<Technology> GetListTechnologies()
        {
            return _technologyRepository.GetAllTechnologies();
        }
    }
}
