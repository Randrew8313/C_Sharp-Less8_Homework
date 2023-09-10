/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}


int[,] GetRandArray(int row, int colums, int minValue = 0, int maxValue = 10)
{
    int[,] matrix = new int[row, colums];
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;   
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) - кол-во строк в массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) - кол-во столбцов в массиве
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, k] > matrix[i, minPosition])
                    {
                        minPosition = k;
                    }
            }        
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temporary;
            
        }
    }
    return matrix;
}

int row = SetNumber("Введите количество строк массива: ");
int col = SetNumber("Введите количество столбцов массива: ");
Console.WriteLine();
int[,] result = GetRandArray(row, col);
PrintArray(result);
Console.WriteLine();
SortArray(result);
PrintArray(result);