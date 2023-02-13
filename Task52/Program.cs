// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArrayRndInt(int horiz, int vert, int min, int max)
{
    int[,] array = new int[horiz, vert];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],5},");
            else Console.Write($"{array[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

double[] AverageVertNumbers(int[,] array)
{
    double[] AverageVert = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int length = array.GetLength(0);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            double average = sum / length;
            AverageVert[j] = Math.Round(average, 1);
        }
       
    }
    return AverageVert;
}

void PrintMas(double[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i < mas.Length - 1) Console.Write($"{Math.Round(mas[i],1),5};");
        else Console.Write($"{Math.Round(mas[i],1),5}  ");
    }
    Console.Write("]");
}

int[,] array2 = CreateArrayRndInt(3, 4, 0, 10);
PrintArray(array2);

double[] arrayAverage = AverageVertNumbers(array2);
Console.WriteLine("Средне арифмитическое равно ->");
PrintMas(arrayAverage);
