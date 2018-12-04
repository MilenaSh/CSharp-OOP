using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        private T[] myList;
        private int capacity;

        public GenericList(int Capacity)
        {
            myList = new T[Capacity];
        }

        // methods

            // Add

            // Access element by Index

            // Remove element by index

            // Insert element at given position

            // Clear the list

            // Find element by value

            // Override ToString method

        // properties

        public T[] MyList
        {
            get
            {
                return this.myList;
            }
            set
            {
                this.myList = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if(value > 0)
                {
                this.capacity = value;
                }
            }
        }

    }
}
