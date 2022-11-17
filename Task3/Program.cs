double[] CreateNewRandomArray (long size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()*100;     //[100, 1000)
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.WriteLine("]");
}

double ReturnMinMaxDifference (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    
    return max-min;
}



Console.Clear();
Console.WriteLine("Пожалуйста, введите количество элементов в массиве");
bool text = Int64.TryParse(Console.ReadLine(), out long mySize);
if (text)
{
    double[] myArray = CreateNewRandomArray(mySize);
    PrintArray(myArray);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {ReturnMinMaxDifference(myArray):f2}");
}
else
{
    Console.WriteLine ("Пожалуйста, введите число!!!");
}
