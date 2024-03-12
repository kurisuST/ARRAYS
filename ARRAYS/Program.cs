class Program
{
    static void Main()
    {
        // One-dimensional array
        int[] oneDimensionalArray = { 1, 2, 3, 4, 5 };
        int oneDimensionalSum = CalculateSum(oneDimensionalArray);

        // Two-dimensional array
        int[,] twoDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        int twoDimensionalSum = CalculateSum(twoDimensionalArray);

        // Jagged array
        int[][] jaggedArray =
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };
        int jaggedSum = CalculateSum(jaggedArray);

        // Print results
        Console.WriteLine("One-dimensional Array:");
        PrintElements(oneDimensionalArray);
        Console.WriteLine("Sum of elements: " + oneDimensionalSum);
        Console.WriteLine();

        Console.WriteLine("Two-dimensional Array:");
        PrintElements(twoDimensionalArray);
        Console.WriteLine("Sum of elements: " + twoDimensionalSum);
        Console.WriteLine();

        Console.WriteLine("Jagged Array:");
        PrintElements(jaggedArray);
        Console.WriteLine("Sum of elements: " + jaggedSum);
    }

    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return sum;
    }

    static int CalculateSum(int[,] array)
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return sum;
    }

    static int CalculateSum(int[][] array)
    {
        int sum = 0;
        foreach (int[] subarray in array)
        {
            foreach (int element in subarray)
            {
                sum += element;
            }
        }
        return sum;
    }

    static void PrintElements(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void PrintElements(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintElements(int[][] array)
    {
        foreach (int[] subarray in array)
        {
            foreach (int element in subarray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}