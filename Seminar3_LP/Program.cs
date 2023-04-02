/*

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine()); // 45678

int firstNum = number/10000; // 4 .. 5678
int secondNum = (number - firstNum*10000)/1000; // 4 .. 5 .. 578
int thirdNum = (number - firstNum*10000 - secondNum*1000)/100;
int fourthNum = (number - firstNum*10000 - secondNum*1000 - thirdNum*100)/10;
int fifthNum = (number - firstNum*10000 - secondNum*1000 - thirdNum*100 - fourthNum*10)%10;

if (firstNum == fifthNum && secondNum == fourthNum)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
else
    {
        Console.WriteLine("Введенное не палиндромом");
    }
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату X первой точки:");
int onePointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
int onePointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки:");
int onePointZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки:");
int twoPointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
int twoPointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки:");
int twoPointZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Pow(
    (
        Math.Pow((twoPointX - onePointX), 2)
      + Math.Pow((twoPointY - onePointY), 2)
      + Math.Pow((twoPointZ - onePointZ), 2)
    ), 0.5);

Console.WriteLine($"Растояние между 2 точками в трехмерном пространстве:\t{distance}");

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/