using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        public int State = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
            Update();
        }

        public override void Update()
        {
            State++;
        }
    }
}
