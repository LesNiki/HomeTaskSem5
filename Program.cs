// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2

// int[] array = new int[4];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine(String.Join(",", array));
// Console.WriteLine(count);


// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// int sum=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100, 100);
// }

// for (int i = 1; i < array.Length; i+=2)
// {
//     sum+=array[i];
// }
// Console.WriteLine(String.Join(",", array));
// Console.Write("Сумма элементов, стоящих на нечетных позициях: ");
// Console.WriteLine(sum);


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// // [3 7 22 2 78] -> 76

// int[] array = new int[5];
// int result = 0;
// int max = int.MinValue; // минимально допустимое число
// int min = int.MaxValue; 

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100, 100);

//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
//     result = max - min;
// }
// Console.WriteLine(String.Join(",", array));
// Console.Write("Разница между максимальным и минимальным элементами массива: ");
// Console.WriteLine(result);