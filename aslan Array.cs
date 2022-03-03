using System;

namespace Program.cs
{
    class Program
    {
        public void sumAverageElements(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine(" Array Cem:" + sum);
            Console.WriteLine("Array Ededi ortasi:" + average);
            Console.ReadLine();

        }
    public static void Main(string[] args)
    {
        int size;
        Console.WriteLine("Olcunu Daxil Et:");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Array reqemlerin daxil et:");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = a.Length;
        Program pg = new Program();
        pg.sumAverageElements(a, len);
    }
    }

}

