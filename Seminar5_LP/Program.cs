/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


            int[] myArr = new int[5];
            Random rand = new Random();
            for (int x = 0; x < myArr.Length; x++)
                {
                    myArr[x] = rand.Next(100, 1000);
                    Console.WriteLine(myArr[x]);
                }
            int a = 0;
            Console.WriteLine("количество четных чисел в массиве:");
            foreach (int i in myArr)
                if (i%2 == 0) 
                a++;
                Console.WriteLine(a);
                     


Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


            int sumIndex = 0;
            int[] myArr = new int[5];
            Random rand = new Random();
            for (int x = 0; x < myArr.Length; x++)
                {
                    myArr[x] = rand.Next();
                    Console.WriteLine(myArr[x]);
                }
            for (int i = 0; i < myArr.Length; i++)
                {
                    if (myArr[i]%2 !=0)
                    {
                        sumIndex = sumIndex + i;
                    }
                }
                Console.WriteLine(sumIndex);


Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

            double[] myArr = new double[5];
            Random rand = new Random();
            for (int x = 0; x < myArr.Length; x++)
                {
                    myArr[x] = rand.Next(10, 100);
                    Console.WriteLine(myArr[x]);
                }
            double min = myArr[0];
            double max = myArr[0];
            for (int i = 0; i < myArr.Length; i++)
                {
                    if (myArr[i] <= min)
                    {
                        min = myArr[i];
                    }
                    else
                    {
                        max = myArr[i];
                    }
                }
                Console.WriteLine($"разница между максимальным {max} значением и минимальным {min} равно:{max-min}");