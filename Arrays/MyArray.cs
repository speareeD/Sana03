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
        protected int IntergersCount = 0;
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

        public void GetMinElement()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < MinElement) MinElement = Array[i];
            }
            Console.WriteLine($"Minimum number: {MinElement}");
        }

        public void GetMaxIndex()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > MaxElementIndex) MaxElementIndex = i;
            }
            Console.WriteLine($"Index of max element: {MaxElementIndex}");
        }

        public void GetMaxAbsElement()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Math.Abs(Array[i]) > MaxAbsElement) MaxAbsElement = Array[i];
            }
            Console.WriteLine($"Max absolute element: {MaxAbsElement}");
        }

        public void GetPositiveIndexSum()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Math.Abs(Array[i]) > 0) PositiveElementsIndexSum += i;
            }
            Console.WriteLine($"Sum of positive number index: {PositiveElementsIndexSum}");
        }

        public void GetAmountIntegers()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 1.0 == 0.0) IntergersCount += 1;
            }
            Console.WriteLine($"Amount of integers: {IntergersCount}");
        }
    }
}
