/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------------------");
Random random = new Random();
int[,] array = new int[rows, columns];

FilLArray(array);
PrintArray(array);
Console.WriteLine("------------------------------------------------");
AverageSummary(array);
Console.WriteLine("------------------------------------------------");



void FilLArray(int[,] A)
{
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = random.Next(1,11);
        }
    }
}
void PrintArray(int[,] A)
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
void AverageSummary(int[,] A)
{
    int count = 0;
    for(int j = 0; j < columns; j++)
    {   
        double summa = 0;
        for(int i = 0; i < rows; i++)
        {
            summa = summa + A[i,j];
            
        }
        count ++;
        double average = summa/rows;
        Console.WriteLine( $"Среднее арифмитическое {count} столбца: " + Math.Round(average, 2));
    }
    
}