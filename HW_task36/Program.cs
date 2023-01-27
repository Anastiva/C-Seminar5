int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); 
    }
    return array;
}

int[] array = new int[7];
FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int sum = 0;
for(int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");