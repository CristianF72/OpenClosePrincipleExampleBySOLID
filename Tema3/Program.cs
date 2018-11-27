using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema3.OpenClose_After;
using Tema3.OpenClose_Before;

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> shapes1 = new List<object>()
            {
                new Rectangle1(){Height = 10, Width = 5},
                new Rectangle1(){Height = 10, Width = 15},
                new Circle1(){Radius = 5.6418958354776},
            };
            var result1 = AreaCalculator1.Area(shapes1.ToArray());

            Console.WriteLine("Result before applying O/C principle: " + result1);

            List<Shape> shapes2 = new List<Shape>()
            {
                new Rectangle2(){Height = 10, Width = 5},
                new Rectangle2(){Height = 10, Width = 15},
                new Circle2(){Radius = 5.6418958354776},
            };
            var result2 = AreaCalculator2.Area(shapes2.ToArray());

            Console.WriteLine("Result after applying O/C principle: " + result2);
        }
    }
}
