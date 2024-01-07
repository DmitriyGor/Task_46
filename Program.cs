/*
Задача 46: 
Задайте двумерный массив размером m x n, заполненный случайными целыми числами
m = 3, n = 4.
1  4  8 19
5 -2 33 -2
77 3  8  1
*/
// Двумерный массив

// Метод для создания массива
// Двумерный массив = matrix
// m - количество строчек, n - количество столбцов
Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());
int[,] resMatrix = GetMatrix(rows, columns, minElements, maxElements);
// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, элемент: число от min до max включительно
PrintMatrix(resMatrix); // PrintMatrix(матрица)
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m,n]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        matrix[i, j] = new Random().Next(min, max+1);
       } 
    }
    return matrix;
}
// Метод, который печатает массив
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
       Console.WriteLine();
    }

}
