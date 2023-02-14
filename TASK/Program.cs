 void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int sizearray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizearray];
string[] arrayout = new string[sizearray];
for (int i = 0; i < sizearray; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}
Console.Write("Ваш массив: ");
PrintArray(array);
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayout[count] = array[i];
        count++;
        }
    }
Console.Write("Ваш новый массив: ");
PrintArray(arrayout);