/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:             Результирующая матрица будет:
2 4 | 3 4                             18 20              
3 2 | 3 3                             15 18        */

// 2*3+4*3 = 18 = resultMatrix[0,0]     2*4+4*3 = 20 = resultMatrix[0,1]
// 3*3+2*3 = 15 = resultMatrix[1,0]     3*4+2*3 = 18 = resultMatrix[1,1]


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,6);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк первой матрицы");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int c1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите количество строк первой матрицы");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int c2 = Convert.ToInt32(Console.ReadLine());


int[,] M1 = new int[r1,c1];
FillMatrix(M1);
PrintMatrix(M1);

int[,] M2 = new int[r2,c2];
FillMatrix(M2);
PrintMatrix(M2);


int [,] resultMatrix = new int[r1,c2];
Console.WriteLine();

if (c1 == r2)
{
    for (int i = 0; i < r1; i++)
    {
        for (int j = 0; j < c2; j++)
        {
            resultMatrix[i,j] = 0;
            for (int a = 0; a < c1; a++)
                {
                resultMatrix[i,j] = resultMatrix[i,j] + (M1[i,a] * M2[a,j]);
                }
        }
    }
   
    Console.WriteLine("Произведение матриц равно:");
    PrintMatrix(resultMatrix);
}
else 
Console.WriteLine("M1 нельзя умножить на M2 т.к. число столбцов M1 не равно числу строк M2");
