using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13Counting_Alligators
{

   
    class Program
    {
        static void Main(string[] args)
        {
            var sheep = new Sheep();
            var cloned = (Sheep)sheep.Clone();
            sheep.sheepName.Replace("E", "a");
            Console.WriteLine(cloned);
        }
    }
}
