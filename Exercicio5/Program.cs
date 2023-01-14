using static System.Console;

//5 - Escreva um programa para ler 2 matrizes N x M (definido pelo usuário) e calcular a soma entre elas
// gerando uma terceira matriz.

Write("Informe o tamanho da linha das matrizes: ");
int rows = int.Parse(ReadLine()!);
Write("Informe o tamanho da coluna das matrizes: ");
int columns = int.Parse(ReadLine()!);

var matrizA = new int[rows, columns];
var matrizB = new int[rows, columns];

MyArrayService.GenerateElements(ref matrizA);
MyArrayService.GenerateElements(ref matrizB);

//int resultSum = MyArrayService.SumOfArrayValues(matrizA, matrizB);
int dimensionSum = MyArrayService.SumOfArrayDimensions(matrizA, matrizB);

WriteLine("Matriz 1 => ");
MyArrayService.PrintMatriz(matrizA);

WriteLine("-----------------");

WriteLine("Matriz 2 => ");
MyArrayService.PrintMatriz(matrizB);

WriteLine("-----------------");

WriteLine("Matriz 3 => ");
var matrizC = MyArrayService.GenerateNewMultidimensionalArray(dimensionSum);
MyArrayService.GenerateElements(ref matrizC);
MyArrayService.PrintMatriz(matrizC);

WriteLine("-----------------");

// --------------------------------------------------

public static class MyArrayService
{
    public static void GenerateElements(ref int[,] matriz)
    {
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                Random random = new Random();
                matriz[i, j] = random.Next(100);
            }
        }
    }

    public static int SumOfArrayValues(int[,] matrizA, int[,] matrizB)
    {
        int sumA = 0;
        int sumB = 0;

        for (int i = matrizA.GetLowerBound(0); i <= matrizA.GetUpperBound(0); i++)
        {
            for (int j = matrizA.GetLowerBound(1); j <= matrizA.GetUpperBound(1); j++)
            {
                sumA += matrizA[i,j];
            }
        }

        foreach(var matrizSum in matrizB)
        {
            sumB += matrizSum;
        }

        return sumA + sumB;
    }

    public static int SumOfArrayDimensions(int[,] matrizA, int[,] matrizB)
    {
        int dimensionSizeA = matrizA.Length;
        int dimensionSizeB = matrizB.Length;

        return dimensionSizeA + dimensionSizeB;
    }

    public static int[,] GenerateNewMultidimensionalArray(int dimensionSize)
    {
        var newMatriz = new int[dimensionSize, dimensionSize];

        return newMatriz;
    }

    public static int[,] GenerateNewMultidimensionalArray(int firstDimensionSize, int lastDimensionSize)
    {
        var newMatriz = new int[firstDimensionSize, lastDimensionSize];

        return newMatriz;
    }

    public static void PrintMatriz(int[,] matriz)
    {
        var sequence = 1;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                WriteLine($"Sequencia: {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i,j]}");
                sequence++;
            }
        }
    }
}