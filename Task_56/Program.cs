/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.Clear();
Console.WriteLine("Задайте количество строк массива ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество колонок массива");
int b = int.Parse(Console.ReadLine());
int[,] array = new int[a, b];
int[] array1 = new int[b];

Array2Random();
Array2(array);
Array2LineCount2in1();
Array1(array1);
Console.WriteLine();
Array1MinIndex();




void Array1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
    }

}
void Array2Random()     //Выводит рандомный двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);

        }
    }
}
void Array2(int[,] array)      //Выводит незаполненный двумерный массив */
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void Array2LineCount2in1() // Считает строки в массиве и выводит на экран
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array1[k] = sum;
        k++;

    }
}
void Array1MinIndex()
{
    int minValue = array1[0];
    int j = 0;
    for (int i = 1; i < array1.Length; i++)
    {
        {
            if (array1[i] < minValue) minValue = array1[i];
            if (array1[i] == minValue) j = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {j + 1} строка");
}
