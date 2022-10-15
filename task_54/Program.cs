/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:    В итоге получается вот такой массив:
1 4 7 2                    7 4 2 1
5 9 2 3                    9 5 3 2
8 4 2 4                    8 4 4 2
*/


void FillArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(10, 51);
        }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   

Console.Write("Введите число строк row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов column = ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] A = new int[row,column];
FillArray(A);
PrintArray(A);
for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1)-1; j++)
        {
            {
                for (int k=0; k<A.GetLength(1)-1-j; k++)
                {
                     if (A[i,k]<A[i,k+1])
                    {
                    int temporary=A[i,k];
                    A[i,k]=A[i,k+1];
                    A[i,k+1]=temporary;
                    }
                }
            }
        }
    }
Console.WriteLine();
PrintArray(A);