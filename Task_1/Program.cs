/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

//Метод для задания размерности
int GetDimension(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) & result > 0)
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

//Метод, задающий матрицу
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

// Метод, печатающий матрицу
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

int getRows = GetDimension("Задайте количество строк: ");
int getColomns = GetDimension("Задайте количество столбцов: ");

double[,] matrix = InitMatrix(getRows, getColomns);
PrintMatrix(matrix);
