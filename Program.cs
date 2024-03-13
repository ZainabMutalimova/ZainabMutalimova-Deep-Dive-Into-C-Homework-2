
class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        AscendingSort(array);
        Console.WriteLine("Итоговый массив");
        PrintArray(array);
    }
    static int[,] AscendingSort(int[,] array)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int l = 0; l < array.GetLength(0); l++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        if (array[i, j] < array[l, m])
                        {
                            temp = array[i, j];
                            array[i, j] = array[l, m];
                            array[l, m] = temp;
                        }
                    }
                }
            }
        }
        return array;
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
