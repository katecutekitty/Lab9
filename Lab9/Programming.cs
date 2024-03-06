using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Programming : Discipline, IHavePractice
    {
        public int PracticeCount { get; set; }
        public Programming(int pc)
        {
            PracticeCount = pc;
            Name = "Программирование";
        }

        public override string Check(Student student)
        {
            string result = $"{student.Name} ";
            if (student.Practices[this] >= PracticeCount) {
                result += "получает автомат!";
            }
            else
            {
                result += " сдал(а) не все практические, значит, никакого автомата!";
            }
            return result;
        }
    }
}
