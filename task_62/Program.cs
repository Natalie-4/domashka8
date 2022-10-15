/* Напишите программу, которая заполнит спирально массив 4 на 4.
 Например, на выходе получается вот такой массив:
 01 02 03 04
 12 13 14 05
 11 16 15 06
 10 09 08 07 */


/*void FillArray1Row(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = 0;
        }
}
*/
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

Console.WriteLine("Введите строки n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбцы m");
int m = Convert.ToInt32(Console.ReadLine());
int [,] Array = new int [n,m];
PrintArray(Array);

void FillArray(int[,] massiv)
 {
    int FirstNumber = 1;
    for (int j = 0; j < n; j++) 
    {
        massiv[0,j] = FirstNumber;
        FirstNumber++;
    }
    for (int i = 1; i < m; i++) 
    {
        massiv[i,n - 1] = FirstNumber;
        FirstNumber++;
    }
    for (int j = n - 2; j >= 0; j--) 
    {
        massiv[m - 1,j] = FirstNumber;
        FirstNumber++;
    }
    for (int i = m - 2; i > 0; i--) 
    {
        massiv[i,0] = FirstNumber;
        FirstNumber++;
    }
        PrintArray(massiv);

int a = 1;
int b = 1;
 
while (FirstNumber < m * n) 
{
    while (massiv[a,b + 1] == 0) 
    {
        massiv[a,b] = FirstNumber;
        FirstNumber++;
        b++;
    }
    
    while (massiv[a + 1,b] == 0) 
    {
        massiv[a,b] = FirstNumber;
        FirstNumber++;
        a++;
    }
    
    while (massiv[a,b - 1] == 0) 
    {
        massiv[a,b] = FirstNumber;
        FirstNumber++;
        b--;
    }
    
    while (massiv[a - 1,b] == 0) 
    {
        massiv[a,b] = FirstNumber;
        FirstNumber++;
        a--;
    }
}
        
PrintArray(massiv);

for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        if (massiv[i,j] == 0) 
        {
            massiv[i,j] = FirstNumber;
        }
    }
}

}

FillArray(Array);
PrintArray(Array);
