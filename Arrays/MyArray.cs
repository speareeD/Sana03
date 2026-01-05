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

        public double GetMaxAbsElement(double[] array)
        {
            if (Math.Abs(GetMinElement(array)) > GetMaxElement(array))
            {
                return GetMinElement(array);
            }
            else
            {
                return GetMaxElement(array);
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
