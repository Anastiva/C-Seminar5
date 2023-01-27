int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200); 
    }
    return array;
}

int[] array = new int[7];
FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}
Console.WriteLine(count);