int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10); 
    }
    return array;
}

int[] array = new int[10];
FillArrayWithRandom(array);

Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

bool isOk = false;
for(int i = 0; i < array.Length; i++)
{
    if(A == array[i])
    {
        isOk = true;
        break;
    }
}
if(isOk)
{
   Console.Write("Элемент найден"); 
}
else
{
    Console.Write("Элемент не найден"); 
}
