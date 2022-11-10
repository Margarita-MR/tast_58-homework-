// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1. Зададим 2 матрицы
// 2. Вычисление произведения матриц
// 3. Вывод всех матриц

// 1. Зададим 2 матрицы


int [,] matrix1 = new int[2, 2];
int [,] matrix2 = new int[2, 2];
Random random = new Random();

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    matrix1[i, j] = random.Next(5);
        {    
        for (int j = 0; j < matrix1.GetLength(1); j++)
        Console.Write(matrix1[i, j] + " ");
        Console.Write(" | | ");
            
    for (int j = 0; j < matrix2.GetLength(1); j++)
    matrix2[i, j] = random.Next(5);
        for (int j = 0; j < matrix2.GetLength(1); j++)
        Console.Write(matrix2[i, j] + " ");
        Console.WriteLine();
        }
}

// 2. Вычисление произведения матриц
// public static Matrix umn(Matrix matrix1, )

int[,] UmnMatrix = Multiplication(matrix1, matrix2);
            Console.WriteLine("Произведение матриц:");
            for (int i = 0; i < UmnMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < UmnMatrix.GetLength(1); j++)
                {
                    Console.Write(UmnMatrix[i, j]);
                }
                Console.WriteLine(" ");
            }
 
static int[,] Multiplication(int[,] a, int[,] b)
{
    if(a.GetLength(1) !=b.GetLength(0)) throw new Exception("Число строк и столбцов должно совпадать");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
             for (int k = 0; k < b.GetLength(0); k++)
             {
                r[i, j] += a[i,k] * b[k, j];
             }
        }  
    }
    return r;
}
    
    
