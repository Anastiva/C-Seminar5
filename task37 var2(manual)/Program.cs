int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10); 
    }
    return array;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int newLength = array.Length/2 + array.Length%2;
int[] newArray = new int [newLength];

for(int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 -i];
}
if(array.Length % 2 > 0)
{
    newArray[newArray.Length - 1] = array[array.Length/2];
}
Console.Write("Ваш получившийся массив: ");
Console.WriteLine(string.Join(", ", newArray));
