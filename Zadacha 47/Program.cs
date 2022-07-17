/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
double[,] array = new double[rows, columns];

FilLArray(array);
PrintArray(array);

void FilLArray(double[,] A)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] =  Math.Round(random.Next(1,20) * random.NextDouble(), 1);
            //array[i,j] = random.Next(1,20) * Math.Round(random.NextDouble(), 1);
        }
    }
}
void PrintArray(double[,] A)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}
