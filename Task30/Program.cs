/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);

void MasRandom(int[] array)
{
    Random rmd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rmd.Next(0, 2);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i < array.Length-1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

Console.WriteLine("Вывод массива:");
int[] mas = new int[8];
MasRandom(mas);
ShowArray(mas);