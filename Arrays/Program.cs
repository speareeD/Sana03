using Arrays;

namespace Sana03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter amount of elements in array: ");
            n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-10, 10) + rand.Next(0, 50) / 100.0;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            MyArray myArray = new MyArray(array);
            Console.WriteLine("Negative sum: " + myArray.GetNegativeSum());
            Console.WriteLine("Minimal element: " + myArray.GetMinElement());
            Console.WriteLine("Max element index: " + myArray.GetMaxIndex());
            Console.WriteLine("Max absolute element: " + myArray.GetMaxAbsElement());
            Console.WriteLine("Sum of positive numbers' indexes: " + myArray.GetPositiveIndexSum());
            Console.WriteLine("Integers: " + myArray.GetAmountIntegers());
        }
    }
}
