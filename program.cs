using System;

public static class Helper
{
    public static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array is empty");

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 99, 3 };
        Console.WriteLine(Helper.FindMax(numbers));
    }
}