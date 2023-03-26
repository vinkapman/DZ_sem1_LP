/* Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Задача № 1 Вывод максимального из двух чисел");
Console.WriteLine("Введите первое число: ");
string numberFirst = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string numberSecond = Console.ReadLine();

double numOne = Convert.ToInt32(numberFirst);
double numTwo = Convert.ToInt32(numberSecond);

if (numOne > numTwo) {
    Console.Write("max = ");
    Console.WriteLine(numOne);
}

else {
    Console.Write("max = ");
    Console.WriteLine(numTwo);
}



Console.WriteLine("Задача № 2 Вывод максимального из трех чисел");
Console.WriteLine("Введите первое число: ");
string numberFirst = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string numberSecond = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string numberThird = Console.ReadLine();

double numOne = Convert.ToInt32(numberFirst);
double numTwo = Convert.ToInt32(numberSecond);
double numThird = Convert.ToInt32(numberThird);

if (numOne > numTwo & numOne > numThird ) {
    Console.Write("max = ");
    Console.WriteLine(numOne);
}

else if (numTwo > numOne & numTwo > numThird ) {
    Console.Write("max = ");
    Console.WriteLine(numTwo);
}

else {
    Console.Write("max = ");
    Console.WriteLine(numThird);
}



Console.WriteLine("Задача № 3 Проверка четности числа");
Console.WriteLine("Введите число: ");
string numberFirst = Console.ReadLine();

double numOne = Convert.ToInt32(numberFirst);
double ostatok = numOne%2;
if (ostatok == 0) {
    Console.WriteLine("Да");
}

else {
    Console.WriteLine("Нет");
}

Console.WriteLine("Задача № 4 Вывод всех четных чисел из промежутка от 1 до N");
Console.WriteLine("Введите число N: ");
string numberN = Console.ReadLine();

double numN = Convert.ToInt32(numberN);
int i = 1;
while (i <= numN) {

    double provNum = i%2; 
    
    if (provNum == 0) {
        Console.Write(i);
        Console.Write(", ");
    }

    i = i + 1;

}