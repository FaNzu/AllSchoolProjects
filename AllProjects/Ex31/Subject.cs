using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.Ex31
{
    public abstract class Subject
    {
        public abstract void Attach(Observer o);
        public abstract void Detach(Observer o);
        public abstract void Notify();
    }
}
