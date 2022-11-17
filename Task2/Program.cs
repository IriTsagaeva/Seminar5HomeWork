double[] CreateNewRandomArray (long size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);     //[100, 1000)
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

double ReturnOddNumbersSum (double[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    
    return sum;
}



Console.Clear();
Console.WriteLine("Пожалуйста, введите количество элементов в массиве");
bool text = Int64.TryParse(Console.ReadLine(), out long mySize);
if (text)
{
    double[] myArray = CreateNewRandomArray(mySize);
    PrintArray(myArray);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {ReturnOddNumbersSum(myArray)}");
}
else
{
    Console.WriteLine ("Пожалуйста, введите число!!!");
}