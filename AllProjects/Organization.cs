using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public abstract class Organization
    {
        public string Name { get; }
        public string Adress { get; set; }

        public Organization(string name)
        {
            Name = name;
        }
    }
}
