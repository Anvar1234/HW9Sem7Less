/*
Примечания:
В задаче 47 сделал вывод и отрицательных чисел тоже. Наверное есть варианты и попроще.
*/

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] GetMatrix(int m, int n)
{
    double[,] newMatrix = new double[m, n];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            // Хотел, чтобы выводились и отрицательные числа
            newMatrix[i, j] = Math.Round(new Random().NextDouble() * (new Random().Next(-50, 51)), 1);
        }

    }
    return newMatrix;
}

void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] result = GetMatrix(rows, columns);

PrintMatrix(result);
*/




/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

Console.Write("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(new Random().Next(1, 7), new Random().Next(1, 7), -10, 10);

PrintMatrix(result);

int rows = result.GetLength(0);
int columns = result.GetLength(1);

if (rowNumber >= 0 && rowNumber < rows && columnNumber >= 0 && columnNumber < columns)
{
    int resultNumber = result[rowNumber, columnNumber];
    Console.WriteLine($"Элемент массива с индексами [{rowNumber}, {columnNumber}] = {resultNumber}");
}
else Console.WriteLine($"В массиве нет элемента с индексами [{rowNumber}, {columnNumber}]");
*/




/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix1Met)
{
    for (int i = 0; i < inputMatrix1Met.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix1Met.GetLength(1); j++)
        {
            Console.Write(inputMatrix1Met[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void PrintAverageOfColumns(int[,] inputMatrix2Met, int rowsMet, int columnsMet)
{
    double average = 0;
    double[] averageArray = new double[columnsMet];

    for (int j = 0; j < columnsMet; j++)
    {
        for (int i = 0; i < rowsMet; i++)
        {
            average += inputMatrix2Met[i, j];
        }
        average = average / rowsMet;
        averageArray[j] = average;
        //Console.WriteLine($"Среднее арифметическое столбца c индексом {j} = {Math.Round(average, 2)}");
        average = 0;
    }
    Console.WriteLine("Среднее арифм. для каждого столбца:");
    Console.WriteLine($"{String.Join("\t", averageArray)}");
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, -10, 10);
PrintMatrix(result);
PrintAverageOfColumns(result, rows, columns);

