/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7*/

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

double[,] InitMatrix(int rows, int colomns)
{
    double[,] matrix = new double[rows, colomns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < colomns; j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble()*20-10, 3);
        }
    }
    return matrix;    
}

double[,] PrintMatrix(double[,] matrix)
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

double FindElementInMatrix(int row, int colomn, double[,] matrix)
{
    if (row >= matrix.GetLength(0) | colomn >= matrix.GetLength(1))
    {
        Console.WriteLine("Элемента в матрице нет");
    }
    else 
    {
        Console.WriteLine($"Искомый элемент: {matrix[row, colomn]}");
    }
return matrix[row, colomn];
}

int row = GetNumber("Укажите строку: ");
int colomn = GetNumber("Укажите столбец: ");

double[,] matrix = InitMatrix(4, 4);
PrintMatrix(matrix);

Console.WriteLine();

double findElement = FindElementInMatrix(row, colomn, matrix);

