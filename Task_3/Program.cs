/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректные данные. Повторите ввод!");
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < colomns; j++)
        {
            matrix[i, j] = rnd.Next(0,10);
        }
    }
    return matrix;    
}

int[,] PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
    return matrix; 
}

double[] ColomnArithmeticMean(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, j];
            } 
         array[j] = Math.Round(sum/matrix.GetLength(0), 1);       
    }    
    return array; 
}

int getRow = GetNumber("Введите количество строк в массиве:");
int getColomn = GetNumber("Введите количество столбцов в массиве:");

int[,] matrix = InitMatrix(getRow, getColomn);
PrintMatrix(matrix);

double[] array = ColomnArithmeticMean(matrix);
Console.Write(string.Join(", ", array));
