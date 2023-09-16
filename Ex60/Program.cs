/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


void GetRandArray3d(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                if(CheckArray3d(array, num))
                    {
                    array[i, j, k] = num;
                    }    
            }
        }
    }
}
bool CheckArray3d(int[,,] array, int num)
{
int ind = 0;
bool res = true;    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == num)
                {
                    ind ++;
                }

            }
        }
    }
    if(ind == 0)
    {
        res = true;
    }
    return res;
}

void PrintdArray3d(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine(); 
        }
    }
}

int x = 2;
int y = 2;
int z = 2;

int[,,] array = new int[x, y, z];

GetRandArray3d(array);
PrintdArray3d(array);