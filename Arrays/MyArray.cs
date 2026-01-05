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
        protected double[] Array;

        public MyArray(double[] array)
        {
            Array = array;
        }

        public double GetNegativeSum()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < 0) NegativeSum += Array[i];
            }
            return Math.Round(NegativeSum, 2);
        }

        public double GetMinElement()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < MinElement) MinElement = Array[i];
            }
            return MinElement;
        }

        public double GetMaxElement()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > MaxElement) MaxElement = Array[i];
            }
            return MaxElement;
        }

        public double GetMaxIndex()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > MaxElement)
                {
                    MaxElement = Array[i];
                    MaxElementIndex = i;
                }
            }
            return MaxElementIndex;
        }

        public double GetMaxAbsElement()
        {
            if (Math.Abs(GetMinElement()) > GetMaxElement())
            {
                MaxAbsElement = GetMinElement();
                return MaxAbsElement;
            }
            else
            {
                MaxAbsElement = GetMaxElement();
                return MaxAbsElement;
            }
        }

        public double GetPositiveIndexSum()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0) PositiveElementsIndexSum += i;
            }
            return PositiveElementsIndexSum;
        }

        public int GetAmountIntegers()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Math.Floor(Array[i])) IntergersCount++;

            }
            return IntergersCount;
        }
    }
}
