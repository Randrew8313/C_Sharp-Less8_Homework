/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

bool CheckRectangleArray(int row, int col)
{
    if(row == col)
    {
        Console.WriteLine("Массив получится не прямоугольный. Введите другие значения.");
        return true;
    }
    return false;
}

void MinSumRowInArray(int[,] matrix)
{   
    int temp = default;
    int result = default;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if(i == 0)
        {
            temp = sum;
            result = i + 1;
        }
        if(temp > sum)
        {
            temp = sum;
            result = i + 1;
        }    
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов № {result}");
}

bool checkArray;
int row;
int col;
do
{
    row = SetNumber("Введите количество строк массива: ");
    col = SetNumber("Введите количество столбцов массива: ");
    checkArray = CheckRectangleArray(row, col);
}
while(checkArray == true);

int[,] result = GetRandArray(row, col);
PrintArray(result);
Console.WriteLine();
MinSumRowInArray(result);
