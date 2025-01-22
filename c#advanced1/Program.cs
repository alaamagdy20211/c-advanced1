namespace c_advanced1
{

    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }


        public Range(T min, T max)
        {

            Min = min;
            Max = max;
        }


        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }


        public double Length()
        {
            if (typeof(T) == typeof(int))
            {
                return Convert.ToInt32(Max) - Convert.ToInt32(Min);
            }
            else if (typeof(T) == typeof(double))
            {
                return Convert.ToDouble(Max) - Convert.ToDouble(Min);
            }
            else if (typeof(T) == typeof(float))
            {
                return Convert.ToSingle(Max) - Convert.ToSingle(Min);
            }
            else
            {
                throw new InvalidOperationException("Length calculation is not supported for this type.");
            }
        }


        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            static void BubbleSort(int[] arr)
            {
                int n = arr.Length;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;


                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {

                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                            swapped = true;
                        }
                    }


                    if (!swapped)
                        break;
                }
            }
            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            //Console.WriteLine("Original array:");

            //foreach (int i in array)
            //{
            //    Console.Write(" "+i);
            //}
            //BubbleSort(array);
            //Console.WriteLine();
            //Console.WriteLine("Sorted array:");
            //foreach (int i in array)
            //{
            //    Console.Write(" " + i);
            //}

            var intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange);
            Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
            Console.WriteLine($"Length of range: {intRange.Length()}");

            var doubleRange = new Range<double>(5.5, 10.5);
            Console.WriteLine(doubleRange);
            Console.WriteLine($"Is 7.5 in range? {doubleRange.IsInRange(7.5)}");
            Console.WriteLine($"Length of range: {doubleRange.Length()}");
        }
    }

}
