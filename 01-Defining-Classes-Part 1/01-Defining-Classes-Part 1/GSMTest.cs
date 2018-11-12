using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class GSMTest
    {

        public void GSMTestMethod()
        {
            GSM[] gsmArray = new GSM[] { new GSM("Sony", "Japan", 250, "Me"), new GSM("Nokia", "Norway", 300, "Steven"), new GSM("Samsung", "Japan") };

            for (int i = 0; i < gsmArray.Length; i++)
            {
                Console.WriteLine(gsmArray[i]);
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
