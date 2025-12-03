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
        protected int MaxElementIndex;
        protected double MaxElement = int.MinValue;
        protected double MaxAbsElement = int.MinValue;
        protected int PositiveElementsIndexSum = 0;
        protected int IntergersCount = 0;

        public void GetNegativeSum(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) NegativeSum += array[i];
            }
            Console.WriteLine($"Sum of negative number: {NegativeSum}");
        }

        public void GetMinElement(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinElement) MinElement = array[i];
            }
            Console.WriteLine($"Minimum number: {MinElement}");
        }

        public void GetMaxIndex(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > MaxElement)
                {
                    MaxElement = array[i];
                    MaxElementIndex = i;
                }
            }
            Console.WriteLine($"Index of max element: {MaxElementIndex}");
        }

        public void GetMaxAbsElement(double[] array)
        {
            if (Math.Abs(MinElement) > MaxElement)
            {
                Console.WriteLine($"Max absolute element: {MinElement}");
            } else
            {
                Console.WriteLine($"Max absolute element: {MaxElement}");
            }
        }

        public void GetPositiveIndexSum(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) PositiveElementsIndexSum += i;
            }
            Console.WriteLine($"Sum of positive number index: {PositiveElementsIndexSum}");
        }

        public void GetAmountIntegers(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 1.0 == 0.0) IntergersCount += 1;
            }
            Console.WriteLine($"Amount of integers: {IntergersCount}");
        }
    }
}
