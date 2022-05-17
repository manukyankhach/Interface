using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doctor doctor = new Doctor();
            //Teacher teacher = new Teacher();
            //Driver driver = new Driver();
            //doctor.Walk();
            //teacher.Walk();
            //driver.Walk();
            List<IWalk> walks = new List<IWalk>();
            walks.Add(new Doctor());
            walks.Add(new Teacher());
            walks.Add(new Driver());
            walks.Add(new FilmReporter());
            for (int i = 0; i < walks.Count; i++)
            {
                walks[i].Walk();
            }
            Console.ReadLine();
        }
    }
}
