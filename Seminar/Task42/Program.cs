// Программа, которая будет рекурсивно выводить каждый элемент массива в консоль
Console.Clear();

int[] array = CreateArray();
FillArray(array);
RecPrintArray(array);

void RecPrintArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
        RecPrintArray(array, index);
    }
}


int[] CreateArray()
{
    int[] array = new int [new Random().Next(4, 10)];
    return array;
}

void FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 11);
    }
} 