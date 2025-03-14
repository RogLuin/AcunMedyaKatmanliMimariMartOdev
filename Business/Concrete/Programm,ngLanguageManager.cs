using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Programm_ngLanguageManager : IProgrammingLanguageService
    {

        private IProgrammingLanguageRepository _programmingLanguageRepository;
        private InMemoryProgrammingLanguageRepository ınMemoryProgrammingLanguageRepository;

        public Programm_ngLanguageManager(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

      

        public void Add(ProgrammingLanguage programmingLanguage)
        {
         _programmingLanguageRepository.Add(programmingLanguage);
        }

        public List<ProgrammingLanguage> GetListProgrammingLanguages()
        {
            return _programmingLanguageRepository.GetProgrammingLanguages();
        }
    }
}
