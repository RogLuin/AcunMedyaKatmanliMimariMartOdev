using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Technology : BaseEntity<int>
    {
        public string TechnologyName { get; set; }
        public string ProgrammingLanguage { get; set; }

        public Technology(int id,string Name, string programmingLanguage)
        {
            Id = id;
            TechnologyName = Name;
            ProgrammingLanguage = programmingLanguage;

        }
        public Technology()
        {
            
        }


    }
}
