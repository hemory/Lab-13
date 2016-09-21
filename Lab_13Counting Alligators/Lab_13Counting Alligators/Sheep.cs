using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13Counting_Alligators
{
    //interface ICloneable
    //{
    //    void clone()
    //}
    class Sheep : ICloneable
    {
        int sheepCount = 0;
  public StringBuilder sheepName { get; set; }
         
        public object Clone()
        {
            
           var sheep = (Sheep) MemberwiseClone();
            sheep.sheepName = new StringBuilder(sheepName.ToString()); 
            return sheep;
        }
    }
}
