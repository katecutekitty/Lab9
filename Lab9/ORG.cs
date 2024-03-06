using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ORG : Discipline, IHaveAngryTeacher
    {
        public ORG() {
            Name = "Основы Российской Государственности";
        }
        public override string Check(Student student)
        {
            return "Этот преподаватель не ставит автоматы!";
        }
    }
}
