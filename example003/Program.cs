// Сортировка массива методом поиска минимального

int[] array = { 9, 8, 3, 7, 9, 1, 6, 2, 5, 4, 3, 2, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);