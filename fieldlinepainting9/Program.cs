using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldlinepainting9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle that you are painting?");
            string useranswer = Console.ReadLine();
            double radius = Convert.ToDouble(useranswer);
            double area = Math.PI * Math.Pow (radius, 2);
            double buckets = Math.Ceiling (area / 100);
    

            Console.WriteLine ("You will need " + buckets + " buckets of paint.");
            Console.ReadLine();


        }
    }
}
