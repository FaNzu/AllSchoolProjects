﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class ConcreteSubject : Subject
    {
        private int state = 0;
        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }
    }
}
