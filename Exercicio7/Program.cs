using static System.Console;

// 7 - Escreva um programa para gerar uma matriz E de dimensão N x M, determinar e imprimir o maior
// e o menor elemento deste conjunto, informando a posição dos mesmos.

int rows = 4;
int columns = 5;

var matrizE = new int[rows, columns];

MyArray myArray = new MyArray();

myArray.GenerateElements(matrizE);
myArray.PrintArrayValues(matrizE);
myArray.PrintSmallestElement(matrizE);
myArray.PrintBiggestElement(matrizE);

// --------------------------

public class MyArray
{
    public int[,] GenerateElements(int[,] array)
    {
        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
            {
                Random random = new Random();

                array[i, j] = random.Next(100);
            }
        }
        return array;
    }

    public void PrintArrayValues(int[,] array)
    {
        WriteLine("------------------------------------------------------------------------------");
        int sequence = 1;
        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
            {
                WriteLine($"Sequencia {sequence}, Linha: {i}, Coluna: {j}, Valor: {array[i, j]}");
                sequence++;
            }
        }
    }

    public void PrintSmallestElement(int[,] array)
    {
        int smallestValue = array[0, 0];
        int row = 0;
        int column = 0;

        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
            {
                var value = array[i, j];

                if (value < smallestValue)
                {
                    smallestValue = value;
                    row = i;
                    column = j;
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        WriteLine("------------------------------------------------------------------------------");
        WriteLine($"O menor valor da matriz é: {smallestValue}, Linha: {row}, Coluna: {column}");
    }

    public void PrintBiggestElement(int[,] array)
    {
        int biggestValue = array[0, 0];
        int row = 0;
        int column = 0;

        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
            {
                var value = array[i, j];

                if (value > biggestValue)
                {
                    biggestValue = value;
                    row = i;
                    column = j;
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        WriteLine("------------------------------------------------------------------------------");
        WriteLine($"O maior valor da matriz é: {biggestValue}, Linha: {row}, Coluna: {column}");
        WriteLine("------------------------------------------------------------------------------");
    }
}