using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class GSM
    {

       const int pricePerMinute = 37;

        // fields
       private string model = null;
       private string manufacturer = null;
       private int? price = null;
       private string owner = null;

       private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 2000, "Me");

       public List<Call> callHistory = new List<Call>();

        // constructors

        public GSM(string model, string manufacturer, int? price, string owner, Battery phoneBattery, Display phoneDisplay)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
        }

        public GSM(string model, string manufacturer, int? price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public GSM(string model, string manufacturer, int? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Display phoneDisplay)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.PhoneDisplay = phoneDisplay;
        }


        // authomatic properties

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int? Price { get; set; }

        public string Owner { get; set; }

        public Battery PhoneBattery { get; set; }

        public Display PhoneDisplay { get; set; }

        public static GSM IPhone4S { get { return iPhone4S; } }

        //public List<Call> CallHistory { get; set; }

        // methods

        public override string ToString()
        {
            // string model, string manufacturer, int? price, string owner, Battery phoneBattery, Display phoneDisplay

            StringBuilder result = new StringBuilder();

            if( this.Model != null)
            {
                result.Append("Model:" + this.Model);
            }

            if (this.Manufacturer != null)
            {
                result.Append("Manufacturer:" + this.Manufacturer);
            }

            if (this.Price > 0 && price != null)
            {
                result.Append("Price:" + this.Price);
            }

            if (this.Owner != null)
            {
                result.Append("Owner:" + this.Owner);
            }

            if (this.PhoneBattery != null && this.PhoneBattery.Model != null)
            {
                result.Append("Battery Model:" + this.PhoneBattery.Model);
            }

            if (this.PhoneBattery != null && this.PhoneBattery.MyBatteryType != null)
            {
                result.Append("Battery Type:" + this.PhoneBattery.MyBatteryType);
            }

            if (this.PhoneDisplay != null && this.PhoneDisplay.Size > 0)
            {
                result.Append(this.PhoneDisplay.Size.ToString());
            }

            return result.ToString();
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall (Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory ()
        {
            this.callHistory.Clear();
        }

        public long CalculateTotalCallPrice ()
        {
            long result = 0;

            foreach (var call in this.callHistory)
            {
                result += ((call.CallDuration / 60) * (pricePerMinute/10));
            }

            return result;
        }


        public string CallDataToString(Call call)
        {
            StringBuilder result = new StringBuilder();

            if (call.CallDate != null)
            {
                result.Append("Calldate:" + call.CallDate.ToLongDateString());
            }

            if (call.CallDuration > 0)
            {
                result.Append("Call duration:" + call.CallDuration.ToString());
            }

            if (call.PhoneNumber != null)
            {
                result.Append("Phone number:" + call.PhoneNumber);
            }

            return result.ToString();
        }


    }

}






