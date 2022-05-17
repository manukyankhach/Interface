using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStep
{
    public interface IWalk
    {
        void Walk();
    }

    public interface IReport
    {
        void Report();
    }

    public class FilmReporter : IReport, IWalk
    {
        public void Report()
        {
            Console.WriteLine("Report");
        }

        public void Walk()
        {
            Console.WriteLine("Report");
        }
    }

    public class Doctor : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Doctors");
        }
    }

    public class Teacher : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Teachers");
        }
    }

    public class Driver : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Drivers");
        }
    }
}
