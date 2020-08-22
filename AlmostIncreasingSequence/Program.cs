using System;

namespace AlmostIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a value: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The statement of your array's almost increasing sequence is {almostIncreasingSequence(array)}");
            Console.ReadLine();
        }
        static bool almostIncreasingSequence(int[] sequence)
        {
            int num = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if(sequence[i] >= sequence[i + 1])
                {
                    num++;
                    if(i != 0 && i != sequence.Length -2 && sequence[i - 1] >= sequence[i + 1] && sequence[i] >= sequence[i + 2])
                    {
                        num++;
                    }
                }
            }
            if(num != 1)
            {
                return false;
            }
            return true;
        }
    }
}
