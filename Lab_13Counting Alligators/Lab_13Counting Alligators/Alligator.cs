using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_13Counting_Alligators
{
    public class Alligator : Countable
    {
        int count = 0;
       public void incrementCount()
        {
            count++;
        }

        public void resetCount()
        {

        }

        public int getCount()
        {
            return count;
        }

        public string getCountStrings()
        {
            return "";
        }
    }

}

