// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Pow(int a, int b)
// {
//     int pow = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         pow = pow * a;
//     }
//     return pow;
// }

// System.Console.Clear();
// System.Console.WriteLine("Enter a number: ");
// int a = System.Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter b number: ");
// int b = System.Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Answer: {Pow(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int CountSummary(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         int digit = number % 10;
//         sum += digit;
//         number = number / 10;
//     }

//     return sum;
// }

// System.Console.Clear();
// System.Console.Write("Enter N: ");

// int n = System.Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Сумма чисел равна = " + CountSummary(n));



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


//ВЕРСИЯ 1 С РУЧНЫМ ВВОДОМ
// System.Console.Clear();
// int[] EnterArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write($"Enter arr[{i}]: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// Console.WriteLine("Enter size array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = EnterArray(size);
// System.Console.WriteLine("Answer: [" + string.Join(", ", arr) + "]");

//ВЕРСИЯ 2 С РАНДОМНЫМ ЗАПОЛНЕНИЕМ
// int[] randomArr(int size, int maxRand)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(0, maxRand);
//     }
//     return arr;
// }

// void showArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

// System.Console.WriteLine("Введите N:");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите maxRand:");
// int maxRand = Convert.ToInt32(Console.ReadLine()) + 1;
// int[] array = randomArr(size, maxRand);
// showArr(array);