namespace Sana03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            double[] array = new double[10];
            double negativeSum = 0;
            double minElement = int.MaxValue;
            double maxElementIndex = int.MinValue;
            double maxAbsElement = int.MinValue;

            Random rand = new Random();
            Console.Write("Enter amount of elements in array: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-10, 11) + rand.Next(0, 100) / 100.0;
                Console.Write(array[i] + " ");
                if (array[i] < 0)
                {
                    negativeSum += array[i];
                }
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
                if (array[i] > maxElementIndex)
                {
                    maxElementIndex = i;
                }
                if (Math.Abs(array[i]) > maxAbsElement)
                {
                    maxAbsElement = array[i];
                }
            }
        }
    }
}
