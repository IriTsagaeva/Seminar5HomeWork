double[] CreateNewRandomArray (long size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);     //[100, 1000)
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[ ");
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("]");
}

int ReturnEvenNumbers (double[] array)
{
    int number = 0;
    foreach (var item in array)
    {
        if (item%2==0)
        {
            number++;
        }
    }
    return number;
}



Console.Clear();
Console.WriteLine("Пожалуйста, введите количество элементов в массиве");
bool text = Int64.TryParse(Console.ReadLine(), out long mySize);
if (text && mySize>0)
{
    double[] myArray = CreateNewRandomArray(mySize);
    PrintArray(myArray);
    Console.WriteLine($"Количество четных чисел - {ReturnEvenNumbers(myArray)}");
}
else
{
    Console.WriteLine ("Пожалуйста, введите число больше нуля!!!");
}
