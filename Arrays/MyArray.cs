using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MyArray
    {
        protected double NegativeSum = 0;
        protected double MinElement = int.MaxValue;
        protected double MaxElementIndex = int.MinValue;
        protected double MaxAbsElement = int.MinValue;
        protected int PositiveElementsIndexSum = 0;
        protected double[] Array;

        public MyArray(double[] array)
        {
            Array = array;
        }

        public void GetNegativeSum()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if(Array[i] < 0) NegativeSum += Array[i];
            }
            Console.WriteLine($"Sum of negative number: {NegativeSum}");
        }
    }
}
