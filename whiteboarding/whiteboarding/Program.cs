using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboarding
{
    class Program
    {
        static void Main(string[] args)
        {
            Luhn(1234567890);
        }

        public static bool Luhn(int value)
        {
            int sum = 0;
            List<int> intList = value.ToString().ToList().Select(x => { return int.Parse(x.ToString()); }).ToList();
            for  (int i=0; i<intList.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + intList[i];
                }
                else
                {
                    sum = sum + (2 * intList[i]);
                }
            }
            int lastValue = intList[intList.Count - 1];
            int test = sum % 10;

                return lastValue==test;
        }

    }
}
