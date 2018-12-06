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
        private int currentElement;

        public GenericList(int capacity)
        {
            myList = new T[capacity];
        }

        // methods

        // Add

        public void AddElement(T element)
        {
            if (myList.Length == currentElement)
            {
                DoubleListSize();
            }

            myList[currentElement] = element;

            currentElement++;

        }

        // Access element by Index

        public T GetElementByIndex(int index)
        {
            T result = myList[index];

            return result;
        }

        // Remove element by index

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index > myList.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {

                T[] newArray = new T[myList.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = myList[i];
                }

                for (int i = index + 1; i < myList.Length - 1; i++)
                {
                    newArray[i] = myList[i + 1];
                }

                myList = newArray;

                currentElement--;

            }
        }

        // Insert element at given position

        public void InsertElement(int index, T value)
        {
            if (index < 0 || index > myList.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] newArray = new T[myList.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = myList[i];
                }

                newArray[index] = value;

                for (int i = index; i < myList.Length + 1; i++)
                {
                    newArray[i = 1] = myList[i];
                }


                myList = newArray;

                currentElement++;

            }
        }

        // Clear the list

        public void Clear()
        {
            T[] newList = new T[currentElement];

            myList = newList;
        }

        // Find element by value

        public int FindElement(T value)
        {
            int index = -1;

            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i].Equals(value))
                {
                    index = i;
                }
            }

            return index;
        }

        // Override ToString method

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < myList.Length; i++)
            {
                result.Append(myList[i]);
            }

            return result.ToString();
        }

        //        Problem 7. Min and Max

        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        //You may need to add a generic constraints for the type T.

        //minimum element
        public T MinElement()
        {
            T minValue = myList[0];

            for (int i = 0; i < currentElement; i++)
            {
                if ((dynamic)minValue > (dynamic)myList[i])
                {
                    minValue = myList[i];
                }
            }

            return minValue;
        }

        //maximum element
        public T MaxElement()
        {
            T maxValue = myList[0];

            for (int i = 0; i < currentElement; i++)
            {
                if ((dynamic)maxValue < (dynamic)myList[i])
                {
                    maxValue = myList[i];
                }
            }

            return maxValue;
        }

        // Auto grow method

        private void DoubleListSize()
        {
            T[] newArray = new T[myList.Length * 2];

            for (int i = 0; i < myList.Length; i++)
            {
                newArray[i] = myList[i];
            }

            myList = newArray;
        }

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

    }
}
