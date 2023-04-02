/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program 
{         
    public static void Main()
    {
		// Задача № 1

        Console.WriteLine("Введите трехзначное число");
		string number = Console.ReadLine();
		int num = Convert.ToInt32(number);
		int num1 = num/100; // количество сотен или первое число
		int num2 = num - num1*100;
		int num3 = num2/10;
		
		Console.WriteLine(num3);
		
		
		// Задача № 2
		
		Console.WriteLine("Введите число"); // 23456
		string number = Console.ReadLine();
		int num = Convert.ToInt32(number);
		int dec = 0;
		int itog = num;
		if (num/100 == 0)
			{
			Console.WriteLine("третьей цифры нет");
			}
		else 
			{
			int i = 10;
				while(num/i > 0)
					{	
					num = num/i;
					dec = dec + 1;
					}
			}
		
		while (itog >= 100)
		{
			
			if (dec == 2)
			{	
			itog = itog%100; // убираем второй десяток
			itog = itog%10;  // убираем первый десяток
			Console.WriteLine(itog);
			}
		dec = dec - 1;
		itog = itog/10;
		}
		
		
        // Задача № 3

		Console.WriteLine("Введите номер дня недели");
		string day = Console.ReadLine();
		int numberDay = Convert.ToInt32(day);

        
		
		switch (numberDay)
		{
        case 1:
            Console.WriteLine("рабочий день");
            break;
        case 2:
            Console.WriteLine("рабочий день");
            break;
        case 3:
            Console.WriteLine("рабочий день");
            break;
        case 4:
            Console.WriteLine("рабочий день");
            break;
        case 5:
            Console.WriteLine("рабочий день");
            break;
        case 6:
            Console.WriteLine("выходной день");
            break;
        case 7:
            Console.WriteLine("выходной день");
            break;
        }
		
	}
}