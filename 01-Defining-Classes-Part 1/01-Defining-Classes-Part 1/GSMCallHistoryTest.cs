using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class GSMCallHistoryTest
    {
        public static void Main()
        {

            GSM Nokia = new GSM("Nokia", "Nokia", 400, "Me");
            Call callOne = new Call(new DateTime(2018, 11, 13), "0876645789", 3000);
            Call callTwo = new Call(new DateTime(2018, 11, 14), "0876645790", 2000);
            Call callThree = new Call(new DateTime(2018, 10, 15), "0876645791", 4000);

            Nokia.AddCall(callOne);
            Nokia.AddCall(callTwo);
            Nokia.AddCall(callThree);

            foreach (var call in Nokia.callHistory)
            {
                Console.WriteLine(Nokia.CallDataToString(call));
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.

            Console.WriteLine("Call price:" + Nokia.CalculateTotalCallPrice().ToString());

            //Remove the longest call from the history and calculate the total price again.

           // Call longestCall;
            long duration = 0;

            foreach (var item in Nokia.callHistory)
            {
                if (item.CallDuration > duration)
                {
                    duration = item.CallDuration;
                    //longestCall = item;
                }
            }

            var itemToRemove = Nokia.callHistory.Single(r => r.CallDuration == duration);

            Nokia.DeleteCall(itemToRemove);

            Console.WriteLine("Call price:" + Nokia.CalculateTotalCallPrice().ToString());

            // Finally clear the call history and print it.

            Nokia.ClearCallHistory();

            Console.WriteLine("Call price:" + Nokia.CalculateTotalCallPrice().ToString());

        }

    }
}
