// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int NumArray)
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

// void ShowArray(int[] array)
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

// int[] CreateRandomArray(int NumArray)
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

// void ShowArray(int[] array)
// {
//     int SumNumOdd = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 != 0)
//             SumNumOdd = SumNumOdd + array[i];
//     }
//     Console.WriteLine($" -> {SumNumOdd}");
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






// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


void[] DifferenceMaxMin(int NumArray)
{
    double min = NumArray
    double[] array = new double[NumArray];
    for (int i = 0; i < NumArray; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    return array;
}

void ShowArray(int[] array)
{
    int SumNumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            SumNumOdd = SumNumOdd + array[i];
    }
    Console.WriteLine($" -> {SumNumOdd}");
}

Console.WriteLine("Вы можете поменять массив чисел руками в программе. Массив такой:");
double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
    for (int i = 0; i = array.Length; i++){
        Console.WriteLine(array[i]);
    }


int NumArray = Convert.ToInt32(Console.ReadLine());

if (NumArray < 1)
{
    Console.WriteLine("Out of range! Need from more 0");
}
else
    Console.WriteLine("How array do you need?");

ShowArray(CreateRandomArray(NumArray));

