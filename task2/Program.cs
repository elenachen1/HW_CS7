/*
Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет
1 2 -> под данным номером стоит число 2
*/
Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
ArrayRandomNumbers(numbers);
PrintArray(numbers);

Console.WriteLine("введите номер строки элемента- ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца элемента- ");
int column = Convert.ToInt32(Console.ReadLine());

if (lines>= line || columns>= column)
{
    Console.WriteLine($"Элемент {numbers[line, column]}");
}

else
{
    Console.WriteLine("Такого элемента не существует");
}


void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}