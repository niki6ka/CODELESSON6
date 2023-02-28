int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

int[] AnotherReverseArray(int[] array)
{
    int[] tmpArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        tmpArray[i] = array[array.Length - 1 - i];
    return tmpArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

int[] array = GenerateArray(10);
PrintArray(array);
PrintArray(AnotherReverseArray(array));
PrintArray(ReverseArray(array));