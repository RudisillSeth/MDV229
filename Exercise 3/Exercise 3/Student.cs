using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Student
    {
        private string _name = null;
        private List<Class> _classes = null;

        public string Getname
        {
            get { return _name; }
        }

        public List<Class> GetClasses
        {
            get { return _classes; }
        }

        public Student(string name, List<Class> classes)
        {
            _name = name;
            _classes = classes;
        }
    }
}
