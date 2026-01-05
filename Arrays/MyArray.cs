using System.Reflection.Metadata.Ecma335;

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

        public double GetNegativeSum(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) NegativeSum += array[i];
            }
            return NegativeSum;
        }

        public double GetMinElement(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinElement) MinElement = array[i];
            }
            return MinElement;
        }

        public double GetMaxElement(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > MaxElement) MaxElement = array[i];
            }
            return MaxElement;
        }

        public double GetMaxIndex(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > MaxElement)
                {
                    MaxElement = array[i];
                    MaxElementIndex = i;
                }
            }
            return MaxElementIndex;
        }

        public double GetMaxAbsElement(double[] array)
        {
            if (Math.Abs(GetMinElement(array)) > GetMaxElement(array))
            {
                MaxAbsElement = GetMinElement(array);
                return MaxAbsElement;
            }
            else
            {
                MaxAbsElement = GetMaxElement(array);
                return MaxAbsElement;
            }
        }

        public double GetPositiveIndexSum(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) PositiveElementsIndexSum += i;
            }
            return PositiveElementsIndexSum;
        }

        public double GetAmountIntegers(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 1.0 == 0.0) IntergersCount += 1;
            }
            return IntergersCount;
        }
    }
}
