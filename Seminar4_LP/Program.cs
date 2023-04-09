/*
   
*/

/*
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

int Stepen (int A, int B)
	{
		int temp = A;
		for (; B >= 0; B--)
			{	
				A = A*temp;
			}
		return(A);
	}
Console.WriteLine("Введите число А:");
int chisloA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int chisloB = Convert.ToInt32(Console.ReadLine());

Console.Write("A в стеепни B = ");
Console.WriteLine(Stepen(chisloA, chisloB));



Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


int SumChisel (string number)
	{
        int t = 0;
		int i = number.Length;
		for (; i > 0; i--)
		    { 	int d = Convert.ToInt32(number[i-1]);
		 		t = t + d;
				// Console.WriteLine($"temp= {t}");
		    }
		return(t);
	}

string chislo = Console.ReadLine();


Console.Write("сумма цифр в числе = ");
Console.WriteLine(SumChisel(chislo));

*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

            // Объявляем массив
            int[] myArr = new int[8];

            // Инициализируем каждый элемент массива вручную
            myArr[0] = 100;
            myArr[1] = 23;
            myArr[2] = 25;
            myArr[3] = 31;
            myArr[4] = 1;
			myArr[5] = 31;
			myArr[6] = 8;
			myArr[7] = 1;


            foreach (int i in myArr)
                Console.Write($"{i} ,");

