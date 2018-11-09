using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes_Part_1
{
    public class GSM
    {

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

        public override string ToString(string model, string manufacturer, int? price, string owner, Battery phoneBattery, Display phoneDisplay)
        {
            var result = "My GSM is" + model + manufacturer + price.ToString() + owner
                + phoneBattery.Model + phoneBattery.HoursIdle.ToString() + phoneBattery.HoursTalk.ToString()
                + phoneDisplay.Size.ToString() + phoneDisplay.NumberOfColors.ToString() + ".";
            return result;
        }
    }

}






