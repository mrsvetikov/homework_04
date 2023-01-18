// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

Method(x, y);

void Method(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// int MethodSum(int x)
// {
//     int length = Convert.ToString(x).Length;
//     int a = 0;
//     int result = 0;

//     for (int i = 0; i < length; i++)
//     {
//         a = x - x % 10;
//         result = result + (x - a);
//         x = x / 10;
//     }
//     return result;
// }

// int sumNumber = MethodSum(x);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел 
// с клавиатуры и далее выводит массив на экран в одну строку.

// Console.Write("Введите восемь целых чисел, разделенных запятой: ");
// string? seriesNum = Console.ReadLine();

// seriesNum = seriesNum + ",";

// string Method01(string series) // функция удаления пробелов из строки
// {
//     string seriesNew = "";
//     for (int i = 0; i < series.Length; i++)
//     {
//         if (series[i] != ' ')
//         {
//             seriesNew += series[i];
//         }
//     }
//     return seriesNew;
// }

// void Method02(int series) //  функция проверки ввода целых чисел
// {

//     if (series == '0' || series == '1' || series == '2'
//     || series == '3' || series == '4' || series == '5' || series == '6'
//     || series == '7' || series == '8' || series == '9' || series == ',')
//     {
//     }
//     else
//     {
//         Console.WriteLine($"Ошибка ввода!");
//     }
// }

// int[] Method03(string seriesNew) // функция создания и заполнения массива
// {

//     int[] arrayOfNumbers = new int[1];
//     int j = 0;

//     for (int i = 0; i < seriesNew.Length; i++)
//     {
//         string seriesNew1 = "";
//         while (seriesNew[i] != ',' && i < seriesNew.Length)
//         {
//             seriesNew1 += seriesNew[i];
//             Method02(seriesNew[i]);
//             i++;
//         }
//         arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
//         if (i < seriesNew.Length - 1)
//         {
//             arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
//         }
//         j++;
//     }
//     return arrayOfNumbers;
// }

// void PrintArray(int[] coll) // функция вывода массива
// {
//     int count = coll.Length;
//     int index = 0;
//     Console.Write("[");
//     while (index < count)
//     {
//         Console.Write(coll[index]);
//         index++;
//         if (index < count)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }

// string series02 = Method01(seriesNum);
// int[] arrayNum = Method03(series02);
// PrintArray(arrayNum);






