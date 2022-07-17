/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[,] array = new int[rows, columns];
Console.WriteLine("Введите индекс строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());


FillArray(array);
Console.WriteLine("------------------- Массив : ---------------------------");
PrintArray(array);
Console.WriteLine($"---------- Массив [строка {rowNumber + 1}, столбец {columnNumber + 1}] -------------------");
SearchElement(array, rowNumber, columnNumber);

void FillArray(int[,] A)
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
void SearchElement(int[,] A, int indexRow, int indexColumn)
{
    if (indexRow < rows & indexColumn < columns)
    {
        int currentNumber = A[indexRow, indexColumn];
        Console.WriteLine($"Искомый элемент: {currentNumber}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

// Задайте массив. Найти сумму эл-ов, с индексами (0,0)(1,1) и т.д
