// Problem 5: Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an 
//            array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing 
//            element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and
//            ToString(). Check all input parameters to avoid accessing elements at invalid positions.
// Problem 6: Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
// Problem 7: Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>. You may need to add a
//            generic constraints for the type T.

using System;
using System.Text;

namespace _05.GenericList
{
    class GenericList<T> where T: IComparable
    {
        private int count;
        private int currIndex;

        private T[] arr;

        public GenericList(int capacity)
        { 
            this.arr = new T [capacity];
            this.currIndex = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new IndexOutOfRangeException("Index was out of range.");
                }
                else
                {
                    return this.arr[index];
                }
            }
        }

        public void AddElement(T element)
        {
            if(this.currIndex == this.arr.Length)
            {
                this.AutoGrow();
            }
            this.arr[currIndex] = element;
            this.count++;
            this.currIndex++;
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Index was out of range.");
            }
            T[] newList = new T[arr.Length - 1];
            Array.Copy(this.arr, 0, newList, 0, position);
            Array.Copy(this.arr, position + 1, newList, position, this.arr.Length - 1 - position);
            this.count--;
            this.arr = newList;
        }

        public void InsertAt(T element, int position)
        {
            if (position < 0 || position >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("Index was out of range.");
            }
            T[] newList = new T[arr.Length + 1];
            Array.Copy(this.arr, 0, newList, 0, position);
            newList[position] = element;
            Array.Copy(this.arr, position, newList, position + 1, this.arr.Length - position);
            this.count++;
            this.arr = newList;
        }

        public int Capacity
        {
            get { return arr.Length;}
        }

        public void Clear()
        {
            this.count = 0;
            this.currIndex = 0;
        }

        public int FindElement(T element)
        {
            return Array.IndexOf(this.arr,element);
        }

        public T Min()
        {
            T minVal = arr[0];
            for (int i = 1; i < this.count; i++)
            {
                if (minVal.CompareTo(arr[i]) > 0)
                {
                    minVal = this.arr[i];
                }
            }
            return minVal;
        }

        public T Max()
        {
            T maxVal = arr[0];
            for (int i = 1; i < this.count; i++)
            {
                if (maxVal.CompareTo(arr[i]) < 0)
                {
                    maxVal = arr[i];
                }
            }
            return maxVal;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                output.Append(string.Format("Index: {0} Value: {1}\n",i, this.arr[i]));
            }

            return output.ToString();
        }

        private void AutoGrow()
        {
            T[] newArray = new T[this.arr.Length * 2];
            for (int i = 0; i < this.arr.Length; i++)
			{
			    newArray[i] = this.arr[i];
			}
            this.arr = newArray;
        }
    }
}
