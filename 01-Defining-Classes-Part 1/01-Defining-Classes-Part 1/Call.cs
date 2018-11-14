using System;

namespace _01_Defining_Classes_Part_1
{
    public class Call
    {
        private DateTime callDate;
        private string phoneNumber;
        private long callDuration;


        public DateTime CallDate
        {
            get
            {
                return this.callDate;
            }
            set
            {
                this.callDate = value;
            }
        }

        public Call(DateTime callDate, string phoneNumber, long callDuration)
        {
            this.CallDuration = callDuration;
            this.PhoneNumber = phoneNumber;
            this.CallDate = callDate;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public long CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                this.callDuration = value;
            }
        }

    }
}
