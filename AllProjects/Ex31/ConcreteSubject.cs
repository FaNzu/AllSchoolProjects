using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.Ex31
{
    public class ConcreteSubject : Subject
    {
        List<Observer> Observers = new List<Observer>();
        public int State
        {
            set
            {
                foreach (ConcreteObserver observer in Observers)
                {
                    observer.State = value;
                }
            }
        }

        public override void Attach(Observer o)
        {
            Observers.Add(o);
        }

        public override void Detach(Observer o)
        {
            Observers.Remove(o);
        }

        public override void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
