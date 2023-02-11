//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minvalue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minvalue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array [i]; // sum = sum + array[i];
    }
    return sum;
}

Console.Write("Input a Length of new array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);

int sumOfNegatives = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negatives is " + sumOfNegatives);
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] RandomArray(int size, int minvalue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minvalue, maxValue + 1);
    }

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
int[] InvertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = -array[i];
    return array;
}

// задача 2
bool IsNumberPresent(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == number)
            return true;
    return false;            
}
//Задача 3
int NumberOfElements(int[] array, int startNumber, int endNumber)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array [i] <= endNumber && array[i] >= startNumber)
            result++;
    return result;
}
Console.Write("Input a Length of new array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a number to search: ");
//int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a start number: ");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a end number: ");
int numEnd = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(Length, min, max);
ShowArray(myArray);
Console.WriteLine($"Number of elements in range [{numStart}, {numEnd}]: {NumberOfElements(myArray, numStart, numEnd)}");
//Console.WriteLine($"number {number} is " + (IsNumberPresent(myArray, number)?"":"not ") + "present" );
//int[] myArray2 = InvertArray(myArray);

//ShowArray(myArray2);

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


//Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].