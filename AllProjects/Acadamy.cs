using AllProjects.Opg2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class Academy : Organization
    {
        public NotifyHandler MessageChanged;
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnMessageChanged();
            }
        }

        public Academy(string name, string address) : base(name)
        {
            Adress = address;
        }

        public void OnMessageChanged()
        {
            MessageChanged();
        }
    }
}
