using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] array = { 2.5, 3.7, -1.8, 5.9, -4.2, 6.1, -2.3, 0.5 };
        double A = -3.0;
        double B = 4.0;

        int countInRange = array.Count(x => x >= A && x <= B);
        Console.WriteLine($"Number of elements in the range from {A} to {B}: {countInRange}");

        int maxIndex = Array.IndexOf(array, array.Max());
        double sumAfterMax = 0;
        if (maxIndex < array.Length - 1)
        {
            sumAfterMax = array.Skip(maxIndex + 1).Sum();
        }
        Console.WriteLine($"Sum of elements in the array after the maximum element: {sumAfterMax}");

        Array.Sort(array, (x, y) => Math.Abs(y).CompareTo(Math.Abs(x)));
        Console.WriteLine("Array after sorting in descending order of absolute values:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        bool hasOddUpperRight = matrix[0, matrix.GetLength(1) - 1] % 2 != 0;
        bool hasOddLowerRight = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] % 2 != 0;
        Console.WriteLine($"Presence of odd numbers in the upper right corner: {hasOddUpperRight}");
        Console.WriteLine($"Presence of odd numbers in the lower right corner: {hasOddLowerRight}");

        bool hasNumberEndingWith5UpperLeft = matrix[0, 0] % 10 == 5;
        bool hasNumberEndingWith5LowerLeft = matrix[matrix.GetLength(0) - 1, 0] % 10 == 5;
        Console.WriteLine($"Presence of numbers ending with 5 in the upper left corner: {hasNumberEndingWith5UpperLeft}");
        Console.WriteLine($"Presence of numbers ending with 5 in the lower left corner: {hasNumberEndingWith5LowerLeft}");
    }
}
