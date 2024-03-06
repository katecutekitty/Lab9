using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class MathAnalysis : Discipline, IHaveFinalControl
    {
        public int PassingScore { get; set; }

        public MathAnalysis(int ps)
        {
            Name = "Математический анализ";
            PassingScore = ps;
        }

        public override string Check(Student student) {
            string result = $"{student.Name} ";
            if (student.FinalControl[this] >= PassingScore) {
                result += "получает автомат!";
            }
            else
            {
                result += " не набрал(а) нужное количество баллов за итоговый тест, поэтому остаётся без автомата!";
            }
            return result;
        }
    }
}
