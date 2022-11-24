// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число  в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16


// Console.WriteLine("Введите число А ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В ");
// int b = Convert.ToInt32(Console.ReadLine());
// Numbers (b);
// int d = 0;
// int Numbers(int b)
// {
//     int c = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         c = c * a;
//     }
//     return c;
// }
// d = Numbers(b);
// Console.WriteLine($"Число {a} в степени {b} = {d}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// void SumNumbers (int n)
// {
//     int a=0;   
//     while (n%10>0 || n>0)
//     {
//         a=a+n%10;
//         n/=10;
//     }

//     Console.WriteLine($"Сумма цифр в числе {a}");    
// }

// SumNumbers (n);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


// int[]array=new int[8];
// void FillArray(int[]collection)
// {
//     int length = 8;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine("Введите элемент массива");
//         int n=Convert.ToInt32(Console.ReadLine());
//         collection[index]=n;
//         index++;
//     }
// }
// void PrintArray(int[]array)
// {
//     int count = 8;
//     for (int i=0; i<count; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.WriteLine();
// }

// FillArray(array);
// PrintArray(array);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateFillArray()
// {
//     int[] arr=new int [4];
//     for (int i=0; i<4; i++)
//     {
//         arr[i]=new Random().Next(100,1000);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void AmNumb(int[] arr)
// {
//     int count=0;
//     foreach (int el in arr)
//     {
//         if (el%2==0) count++;
//     }
//     Console.WriteLine(count);    
// }

// int[]mas=CreateFillArray();
// AmNumb(mas);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateFillArray()
// {
//     int[] arr=new int [4];
//     for (int i=0; i<4; i++)
//     {
//         arr[i]=new Random().Next(-99,100);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void Summ(int[] arr)
// {
//     int sum=0;
//     for (int j=1; j<4; j=j+2)
//     {
//         sum=sum+arr[j];
//     }
//     Console.WriteLine(sum);    
// }

// int[]mas=CreateFillArray();
// Summ(mas);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// double[] mas = {1.23, 0, -50.0001, 300.0}; //задаём массив вещественных чисел
// Console.WriteLine($"mas: {mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}");  //вывод на печать заданного массива
// int n = mas.Length; // определяем кол-во элементов массива
// //Console.WriteLine(n);   //вывод на печать кол-во элементов массива

// double max = mas[0];
// for (int i=0; i<n; i++)
//     {
//         if (mas[i] > max) 
//         {
//         max=mas[i];
//         }
//     }
// //Console.WriteLine(max); //вывод на печать max

// double min = mas[0];
// for (int j=0; j<n; j++)
//     {
//         if (mas[j] < min) 
//         {
//         min=mas[j];
//         }
//     }
// //Console.WriteLine(min); //вывод на печать min

// Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max-min}"); 


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] mas = {1.23, 0, -50.0001, 300.0}; //задаём массив вещественных чисел
Console.WriteLine($"mas: {mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}");  //вывод на печать заданного массива
int n = mas.Length; // определяем кол-во элементов массива
//Console.WriteLine(n);   //вывод на печать кол-во элементов массива
double[] Max (double[] mas)
{
    double max = mas[0];
    double min = mas[0];
    for (int i=0; i<n; i++)
        {
            if (mas[i] > max) max=mas[i];
            if (mas[i] < min) min=mas[i];
        }
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max-min}");
        return mas; 
}    
Max (mas);