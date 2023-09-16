/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int SetNumber(string message)
{
    Console.Write(message);
    string arrLength = Console.ReadLine();
    int result = int.Parse(arrLength);
    return result;
}
int MoveLeft(int[,] array, int startRow, int startCol, int res)
{
    while(startCol < array.GetLength(1) && array[startRow, startCol] == 0)
    {
        array[startRow, startCol] = res;
        startCol ++;
        res ++;
    }
    return res;
}
int MoveDown(int[,] array, int startRow, int startCol, int res)
{
    while(startRow < array.GetLength(0) && array[startRow, startCol] == 0)
    {
        array[startRow, startCol] = res;
        startRow ++;
        res ++;
    }
    return res;
}
int MoveRight(int[,] array, int startRow, int startCol, int res)
{
    while(startCol >= 0 && array[startRow, startCol] == 0)
    {
        array[startRow, startCol] = res;
        startCol --;
        res ++;
    }
    return res; 
}
int MoveUP(int[,] array, int startRow, int startCol, int res)
{
    while(startRow >= 0 && array[startRow, startCol] == 0)
    {
        array[startRow, startCol] = res;
        startRow --;
        res ++;
    }
    return res;
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

int index = SetNumber("Введите размер массива (целое число больше нуля): ");;
int[,] array = new int[index, index];
int startRow = 0;
int startCol = 0;
int x = startRow;
int y = startCol;
int endRow = array.GetLength(0);
int endCol = array.GetLength(1);
int res = 1;
int round = 0;

while(round < (index+1)/2)
{
    x = round;
    y = round;
    res = MoveLeft(array, x, y, res);

    x = x + 1;
    y = endCol-1 - round;
    res = MoveDown(array, x, y, res);

    x = y;
    y = y - 1;
    res = MoveRight(array, x, y, res);

    x = y;
    y = startCol + round;
    res = MoveUP(array, x, y, res);  
    round ++;
}

PrintArray(array);




