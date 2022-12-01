using AllProjects.Opg2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllProjects
{
    public class Student : Person, IObserver
    {
        public Academy academy;
        public string Message { get; set; }

        public Student(Academy academy, string name) : base(name)
        {
            this.academy= academy;
        }

        public void Update()
        {
            Message = academy.Message;
            Console.WriteLine($"Message:{Name} {Message}, {academy.Name}");
        }
    }
}
