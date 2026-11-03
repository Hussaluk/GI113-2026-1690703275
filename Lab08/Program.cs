using System.Diagnostics;

namespace Lab08
/*
* Student ID : 1690703275
* Name       : Hussaluk Sriprasert
* Section    : 129C
* No.        : 31
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            float average;
            int maximum;
            int minimum;
            int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
                }
            }

            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);



            maximum = numbers[0];
            minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);

            System.Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);

            }
                Console.WriteLine("\nPart B");

                int sum1;
                float average1;
                int maximum1;
                int minimum1;
                int[] numbers1 = { 7, 11, 10, 83, 77, 24, 69, };
                {
                    for (int i = 0; i < numbers1.Length; i++)
                    {
                        Console.WriteLine("Number " + (i + 1) + ": " + numbers1[i]);
                    }
                }

                sum1 = 0;
                for (int i = 0; i < numbers1.Length; i++)
                {
                    sum1 += numbers1[i];
                }
                average1 = (float)sum1 / numbers1.Length;
                Console.WriteLine("Sum: " + sum1);
                Console.WriteLine("Average: " + average1);



                maximum1 = numbers1[0];
                minimum1 = numbers1[0];
                for (int i = 1; i < numbers1.Length; i++)
                {
                    if (numbers1[i] > maximum1)
                    {
                        maximum1 = numbers1[i];
                    }
                    if (numbers1[i] < minimum1)
                    {
                        minimum1 = numbers1 [i];
                    }
                }
                Console.WriteLine("Maximum: " + maximum1);
                Console.WriteLine("Minimum: " + minimum1);

                System.Array.Sort(numbers1);
                foreach (int n in numbers1)
                {
                    Console.WriteLine("Sorted: " + n);

                }
            
        }
    }
}
