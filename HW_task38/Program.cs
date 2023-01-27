double[] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(1,100); 
    }
    return array;
}

double[] array = new double[5];
FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

double max = 0;
double min = 1000;
double dif = 0;

for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
    if(min > array[i])
    {
        min = array[i];
    }
}
dif = max - min;
Console.WriteLine(" ");
Console.WriteLine($"Максимальное число: {max} ");
Console.WriteLine($"Минимальное число: {min} ");
Console.WriteLine($"Разница: {dif} ");