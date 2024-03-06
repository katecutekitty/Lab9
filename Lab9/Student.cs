using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Student
    {
        public string Name { get; set; }
        public Dictionary<Discipline, int> Practices;
        public Dictionary<Discipline, int> FinalControl;
    }
}
