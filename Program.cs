// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int minNumber = 1;
int maxNumber = 100;

int minInTheRange = 20;
int maxinTheRange = 90;
int arraySize = 10;

int[] arrayOfnumbers = new int[arraySize];
Random rand = new Random();

for (int i = 0; i < arraySize; i++)
{
    arrayOfnumbers[i] = rand.Next(minNumber, maxNumber);
}

Console.Write("В данном массиве [");

int count = 0;
for (int i = 0; i < arraySize; i++)
{
    if (i > 0)
        Console.Write($", ");

    int currentNumber = arrayOfnumbers[i];
    if (currentNumber >= minInTheRange && currentNumber <= maxinTheRange)
      ++count;
    Console.Write($"{currentNumber}");
   
}

Console.WriteLine($"] {count} чисел находится в диапазоне [{minInTheRange}, {maxinTheRange}]");

// ЗАДАЧА 2

