using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Discipline history = new History(5, 80);
            Discipline org = new ORG();
            Discipline programming = new Programming(12);
            Discipline mathan = new MathAnalysis(90);
            List <Discipline> disciplines = new List<Discipline>
            {
             history, org, programming, mathan   
            };
            

            Student st1 = new Student();
            st1.Name = "Александров Александр";
            st1.Practices = new Dictionary<Discipline, int>();
            st1.FinalControl = new Dictionary<Discipline, int>();
            st1.Practices.Add(history, 10);
            st1.Practices.Add(programming, 15);
            st1.FinalControl.Add(history, 79);
            st1.FinalControl.Add(mathan, 91);
            Student st2 = new Student();
            st2.Name = "Смирнова Мария";
            st2.Practices = new Dictionary<Discipline, int>();
            st2.FinalControl = new Dictionary<Discipline, int>();
            st2.Practices.Add(history, 4);
            st2.Practices.Add(programming, 9);
            st2.FinalControl.Add(history, 40);
            st2.FinalControl.Add(mathan, 80);
            Student st3 = new Student();
            st3.Name = "Кириллов Кирилл";
            st3.Practices = new Dictionary<Discipline, int>();
            st3.FinalControl = new Dictionary<Discipline, int>();
            st3.Practices.Add(history, 5);
            st3.Practices.Add(programming, 12);
            st3.FinalControl.Add(history, 80);
            st3.FinalControl.Add(mathan, 90);

            List<Student> students = new List<Student>() {  st1, st2, st3 };

            foreach (var discipline in disciplines)
            {
                Console.WriteLine($"{discipline.Name}\n");
                if (discipline is IHaveAngryTeacher)
                {
                    Console.WriteLine(discipline.Check(st1));
                }
                else
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine(discipline.Check(student));
                    }
                }
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            }
        }
    }
}
