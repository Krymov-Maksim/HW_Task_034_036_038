// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int NumArray)        // Метод. Создает рандомный массив размером NumArray элеменов
// {
//     Console.Write("[");
//     int[] array = new int[NumArray];
//     for (int i = 0; i < NumArray; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
//     return array;
// }

// void ShowArray(int[] array)                  // Метод. Ищем четные элементы массива, складываем их в SumNumEven. Вывод на экран
// {
//     int SumNumEven = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             SumNumEven ++;
//     }
//     Console.WriteLine($" -> {SumNumEven}");
// }

// Console.WriteLine("How array do you need?");
// int NumArray = Convert.ToInt32(Console.ReadLine());
// if (NumArray < 1)
// {
//     Console.WriteLine("Out of range! Need from more 0");
// }
// else
//     Console.WriteLine("How array do you need?");

// ShowArray(CreateRandomArray(NumArray));



// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int NumArray)                    // Метод. Создает рандомный массив размером NumArray элеменов
// {
//     Console.Write("[");
//     int[] array = new int[NumArray];
//     for (int i = 0; i < NumArray; i++)
//     {
//         array[i] = new Random().Next(-1000, 1000);
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
//     return array;
// }

// void ShowArray(int[] array)                              // Метод. Считаем сумму всех нечетных позиций. 
// {
//     int SumNumOdd = 0;
//     for (int i = 1; i < array.Length; i = i+2)
//     {                        
//             SumNumOdd = SumNumOdd + array[i];
//     }
//     Console.WriteLine($" -> {SumNumOdd}");
// }

// Console.WriteLine("How array do you need?");            // Тело
// int NumArray = Convert.ToInt32(Console.ReadLine());
// if (NumArray < 1)                                       // Количество элементов в массиве не должно быть меньше 1
// {
//     Console.WriteLine("Out of range! Need from more 0");
// }
// else
//     Console.WriteLine("How array do you need?");

// ShowArray(CreateRandomArray(NumArray));






// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// void DiffMaxMin (double [] array)               // Метод определеющие минимум и максимиум в массиве. Считает разницу DIFF
// {
//     double min = array[0];
//     double max = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)   
//             min = array[i];
//         if (array[i] > max)   
//             max = array[i];
//     }        
//     Console.WriteLine($"Difference between max {max} and {min} is {max - min} pounts.");
// }

// Console.WriteLine("Вы можете поменять массив чисел руками в программе. Массив такой:");   // Тело
// double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
    
//     for (int i = 0; i < array.Length; i++){                                      // Выводим массив на экран
//         Console.Write(array[i] + " ");
//     }

// DiffMaxMin(array);

