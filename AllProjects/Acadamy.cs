using AllProjects.Opg2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class Academy : Organization, ISubject
    {
        private List<IObserver> students = new List<IObserver>();
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }


        public Academy(string name, string address) : base(name)
        {
            Adress = address;
        }

        public void Attach(IObserver o)
        {
            students.Add(o);
        }

        public void Detach(IObserver o)
        {
            students.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver observer in students)
            {
                observer.Update();
            }
        }
    }
}
