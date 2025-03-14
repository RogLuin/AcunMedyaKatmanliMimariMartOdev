using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProgrammingLanguageRepository
    {
        void Add(ProgrammingLanguage programmingLanguage);
        void Delete(int id);

        void Update(int id, ProgrammingLanguage programmingLanguage);

        List<ProgrammingLanguage> GetProgrammingLanguages();

        List<ProgrammingLanguage> GettById(int id);


    }
}
