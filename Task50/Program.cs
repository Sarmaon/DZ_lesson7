// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = 4;
int n = 3;
int [,] array = new int [m, n];
Console.WriteLine("Введите значение ");
int number = Convert.ToInt32 (Console.ReadLine());
FillArray (array);
FindElementArray (array, number);

void FillArray (int [,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
       for (int j = 0; j < arrayToFill.GetLength(1); j++)
       {
            array [i,j] = new Random().Next(1,10);
            Console.Write (array [i,j] + " ");
       } 
       Console.WriteLine();
    }
}

void FindElementArray (int [,] findElement, int userNumber)
{
    bool find = false;

    for (int i = 0; i < findElement.GetLength(0); i++)
    {
       for (int j = 0; j < findElement.GetLength(1); j++)
       {
            if (findElement [i,j] == userNumber)
            Console.WriteLine("Заданное значение находится по координатам " + i + " " + j);
            find = true;
       } 
    }
    if (!find)
    Console.WriteLine("Такого значения в массиве нет");
}
