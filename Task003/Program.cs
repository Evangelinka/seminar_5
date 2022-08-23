// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное
// число в массиве.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            {
                Console.WriteLine("Да");
                return;
            }
    }
    Console.WriteLine("Нет");
}
int[] array = CreateArray(7, 0, 10);
PrintArray(array);
FindNumber(array, 5);