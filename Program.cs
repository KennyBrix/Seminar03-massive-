// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int minNumber = 1;
// int maxNumber = 100;

// int minInTheRange = 20;
// int maxinTheRange = 90;
// int arraySize = 10;

// int[] arrayOfnumbers = new int[arraySize];
// Random rand = new Random();

// for (int i = 0; i < arraySize; i++)
// {
//     arrayOfnumbers[i] = rand.Next(minNumber, maxNumber);
// }

// Console.Write("В данном массиве [");

// int count = 0;
// for (int i = 0; i < arraySize; i++)
// {
//     if (i > 0)
//         Console.Write($", ");

//     int currentNumber = arrayOfnumbers[i];
//     if (currentNumber >= minInTheRange && currentNumber <= maxinTheRange)
//       ++count;
//     Console.Write($"{currentNumber}");

// }

// Console.WriteLine($"] {count} чисел находится в диапазоне [{minInTheRange}, {maxinTheRange}]");

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// int arraySize = 10;

// int[] arrayOfnumbers = new int[arraySize];
// Random rand = new Random();

// for (int i = 0; i < arraySize; i++)
// {
//     arrayOfnumbers[i] = rand.Next(1, 100);
// }

// Console.Write("В данном массиве [");

// int evenNumbers = 0;

// for (int i = 0; i < arraySize; i++)
// {
//     if (i > 0)
//         Console.Write($", ");

//     int currentNumber = arrayOfnumbers[i];

//     if (currentNumber % 2 == 0)
//         ++evenNumbers;

//     Console.Write($"{currentNumber}");

// }

// Console.WriteLine($"] => {evenNumbers}  чётных ");

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

int minNumber = 1;
int maxNumber = 100;

int arraySize = 10;

double[] arrayOfnumbers = new double[arraySize];
Random rand = new Random();

double min = double.MaxValue;
double max = double.MinValue;

for (int i = 0; i < arraySize; ++i)
{
    double fractionalPart = 0;
    while (fractionalPart == 0)
    {
        fractionalPart = rand.NextDouble();
    }

    double currentnumber = Math.Round(rand.Next(minNumber, maxNumber) + fractionalPart, 2);
    arrayOfnumbers[i] = currentnumber;

    if (min > currentnumber)
        min = currentnumber;

    if (max < currentnumber)
        max = currentnumber;
}

Console.Write("Разница между максимальным и минимальным элементами\n в массиве [");

for (int i = 0; i < arraySize; ++i)
{
    if (i > 0)
        Console.Write($", ");

    double currentNumber = arrayOfnumbers[i];
  
    Console.Write($"{currentNumber}");
}

Console.WriteLine($"] => {max - min}");