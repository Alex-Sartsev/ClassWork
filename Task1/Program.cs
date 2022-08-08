//Напишите программу, которая принимает 
// на вход два числа и проверяет, является
// ли первое число
// квадратом второго
// 5 -> 25 (истина)
// -7 -> 49 (истина)
// 6 -> 39 (ложь)
// 9 -> 14 (ложь)

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if(num2*num2 == num1) Console.WriteLine($"Число {num1} является квадратом числа {num2}");
else Console.WriteLine($"Число {num1}, НЕ является квадратом числа {num2}");