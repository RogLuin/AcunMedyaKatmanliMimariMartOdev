using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProgrammingLanguage:BaseEntity<int>
    {
        public string ProgrammingLanguageName { get; set; }

        public ProgrammingLanguage(int id, string name)
        {
            Id = id;
            ProgrammingLanguageName = name;

        }
        public ProgrammingLanguage()
        {
            
        }


    }
}
