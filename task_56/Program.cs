/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillArray(int[,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
        for (int j = 0; j < M.GetLength(1); j++)
        {
            M[i, j] = new Random().Next(0, 11);
        }
}
void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($" {A[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   

Console.Write("Введите число строк массива row:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива column: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] Array = new int[row,column];
FillArray(Array);


int [] ArraySum = new int[Array.GetLength(0)];

for (int i = 0; i < Array.GetLength(0); i++)
    {   for (int j = 0; j < Array.GetLength(1); j++)
        {
            ArraySum[i] = ArraySum[i] + Array[i,j];
                     
        }
    }

int Min = ArraySum[0];
int NumberOfRow = 0;
for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (ArraySum[i] < Min)
        {
            Min = ArraySum[i];
            NumberOfRow = i;
        }   
    }

Console.WriteLine();
PrintArray(Array);
Console.Write($"Номер строки с наименьшей суммой элементов: {NumberOfRow+1}");

