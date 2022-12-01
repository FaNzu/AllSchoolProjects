using System;
namespace AllProjects
{
    public delegate void NotifyHandler();

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
            Address = address;

        }

        public void OnMessageChanged()
        {
            MessageChanged();
        }
    }
}

