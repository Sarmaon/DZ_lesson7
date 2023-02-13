// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = 3, n = 4;
double[,] array = new double[m,n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        array [i,j] = (double)rand.Next(-100,100)/10;
        Console.Write(array[i,j] + " / ");
    }
    Console.WriteLine();
}