using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class GSM
    {

        // fields

       private string model = null;
       private string manufacturer = null;
       private int? price = null;
       private string owner = null;

       private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple");

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

        // methods

        public override string ToString()
        {
            // string model, string manufacturer, int? price, string owner, Battery phoneBattery, Display phoneDisplay

            StringBuilder result = new StringBuilder();

            if( model != null)
            {
                result.AppendLine("Model:" + this.Model);
            }

            if (manufacturer != null)
            {
                result.AppendLine("Manufacturer:" + this.Manufacturer);
            }

            if (price > 0 && price != null)
            {
                result.AppendLine("Price:" + this.Price);
            }

            if (owner != null)
            {
                result.AppendLine("Owner:" + this.Owner);
            }

            if (PhoneBattery != null && PhoneBattery.Model != null)
            {
                result.AppendLine("Battery Model:" + this.PhoneBattery.Model);
            }

            if (PhoneBattery != null && PhoneBattery.MyBatteryType != null)
            {
                result.AppendLine("Battery Type:" + this.PhoneBattery.MyBatteryType);
            }

            if (PhoneDisplay != null && PhoneDisplay.Size > 0)
            {
                result.Append(this.PhoneDisplay.Size.ToString());
            }

            return result.ToString();
        }
    }

}






