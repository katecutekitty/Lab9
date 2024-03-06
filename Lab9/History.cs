using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class History : Discipline, IHavePractice, IHaveFinalControl
    {
        public int PracticeCount { get; set; }
        public int PassingScore { get; set; }
        public History(int pc, int ps) {
            Name = "История";
            PracticeCount = pc;
            PassingScore = ps;
         }

        override public string Check(Student st)
        {
            string result = $"{st.Name} ";
            if (st.FinalControl[this] >= PassingScore && st.Practices[this] >= PracticeCount)
            {
                result += "получает автомат!";
            }
            else
            {
                 if (st.FinalControl[this] < PassingScore && st.Practices[this] >= PracticeCount)
                {
                    result += "не набрал нужное количество баллов за финальный тест и не получает автомат :(";
                }
                if (st.FinalControl[this] >= PassingScore && st.Practices[this] < PracticeCount)
                {
                    result += "не сдал необходимое количество практических работ и не получает автомат :(";
                }
                else result += "не выполнил(а) ни одно из требований и не получает автомат :(";
            }
            return result;
        }
    }
}
