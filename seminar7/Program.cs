/*TASK1  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    double [,] newArray = new double [rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {   
        for(int j = 0; j < columns; j++)
        {
         newArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    } 
    return newArray;
}

void Show2DArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter numbers of row: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of column: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] array = CreateRandom2DArray(m,n,-10,10);
Show2DArray(array);*/

/*TASK2 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
          newArray [i,j] = new Random().Next (minValue, maxValue +1);
        }
    } 
    return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the row number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the columns numbers : ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter min value of element: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter max value of element: ");
//int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2DArray(7,7,0,100);
Show2DArray(array);
if (m < 0 | m > array.GetLength(0) | n < 0 | n > array.GetLength(1)) Console.Write("The element does not exist");
else Console.Write($"The element of the {n} row and {m} column element is {array[n,m]}");*/

/*TASK3 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
          newArray [i,j] = new Random().Next (minValue, maxValue +1);
        }
    } 
    return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] Arithmetic (int [,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double arithmean = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        { 
            arithmean += array[i,j];
        }
        Console.WriteLine($"The arithmetic mean of the elements in each column:{arithmean/array.GetLength(0)}");
    }  return array;
}

Console.Write("Enter numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2DArray(m,n,min,max);
Show2DArray(array);
int [,] arithmetic = Arithmetic (array);*/
