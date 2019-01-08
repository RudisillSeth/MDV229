using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Class
    {
        private string _className = null;
        private double _grade = 0;

        public string ClassName
        {
            get { return _className; }
        }

        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public Class(string name, double grade)
        {
            _className = name;
            _grade = grade;
        }
    }
}
