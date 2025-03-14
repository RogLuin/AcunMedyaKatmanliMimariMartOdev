using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryProgrammingLanguageRepository : IProgrammingLanguageRepository
    {

        private List<ProgrammingLanguage> _programmingLanguagesRepository;

        public InMemoryProgrammingLanguageRepository()
        {
            _programmingLanguagesRepository = new List<ProgrammingLanguage>
            {
                new ProgrammingLanguage{Id=1,ProgrammingLanguageName="C#"},
                new ProgrammingLanguage{Id=2,ProgrammingLanguageName="Java"},
                new ProgrammingLanguage{Id=3,ProgrammingLanguageName="Python"},
                new ProgrammingLanguage{Id=4,ProgrammingLanguageName="JavaScript"},
                new ProgrammingLanguage{Id=5,ProgrammingLanguageName="C++"},
                new ProgrammingLanguage{Id=6,ProgrammingLanguageName="Ruby"},     
                new ProgrammingLanguage{Id=8,ProgrammingLanguageName="Kotlin"},
                new ProgrammingLanguage{Id=9,ProgrammingLanguageName="Go"},           
            };
        }


        public void Add(ProgrammingLanguage programmingLanguage)
        {
            _programmingLanguagesRepository.Add(programmingLanguage);
        }

        public void Delete(int id)
        {
            var programmingLanguageToDelete = _programmingLanguagesRepository.SingleOrDefault(p => p.Id == id);
            if(programmingLanguageToDelete != null)
            {
                _programmingLanguagesRepository.Remove(programmingLanguageToDelete);
            }
            else
            {
                throw new Exception("Programming Language not found");
            }
        }

        public List<ProgrammingLanguage> GetProgrammingLanguages()
        {
            return _programmingLanguagesRepository;
        }

        public List<ProgrammingLanguage> GettById(int id)
        {
            return _programmingLanguagesRepository.FindAll(p => p.Id == id);
        }

        public void Update(int id, ProgrammingLanguage programmingLanguage)
        {
            var programmingLanguageToUpdate = _programmingLanguagesRepository.SingleOrDefault(p => p.Id == id);
            if(programmingLanguageToUpdate != null)
            {
                programmingLanguageToUpdate.ProgrammingLanguageName = programmingLanguage.ProgrammingLanguageName;
                programmingLanguageToUpdate.Id = programmingLanguage.Id;

            }
            else
            {
                throw new Exception("Programming Language not found");
            }
        }
    }
}
