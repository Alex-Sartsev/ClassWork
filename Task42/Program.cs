// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());

int result = 0;
int mult = 1;
while(num > 0)
{
    result += num % 2 * mult;
    num = num / 2;
    mult *= 10;
}

Console.WriteLine(result);

// Рекурсия:
// int number = 13;

// void DecToBin(int num)
// {
//     if(num == 0) return;
//     DecToBin(num / 2);
//     Console.Write(num % 2); 
// }

// DecToBin(number);
