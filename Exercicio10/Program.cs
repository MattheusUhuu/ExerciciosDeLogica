// 10 - Escreva um programa para gerar uma matriz quadrada H de dimensão N. Imprimir os elementos da diagonal secundária 
// (linha + coluna = dimensão + 1).

var array = new int[4, 4];

var myArray = new MyArray();

myArray.GenerateElements(array);
myArray.Print(array);
System.Console.WriteLine("-------------------");
myArray.PrintSecondaryDiagonalElements(array);

// -------------------

public class MyArray
{
    public int[,] GenerateElements(int[,] matriz)
    {
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                Random random = new Random();

                matriz[i, j] = random.Next(100);
            }
        }

        return matriz;
    }

    public void Print(int[,] matriz)
    {
        var sequence = 1;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                Console.WriteLine($"Sequencia {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i, j]}");
                sequence++;
            }
        }
    }

    public void PrintSecondaryDiagonalElements(int[,] matriz)
    {
        var sequence = 1;
        Console.WriteLine("Diagonal Secundária.");
        for (int i = matriz.GetUpperBound(0); i >= matriz.GetLowerBound(0); i--)
        {
            for (int j = matriz.GetUpperBound(1); j >= matriz.GetLowerBound(1); j--)
            {
                i = j;
                Console.WriteLine($"Sequencia {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i, j]}");
                sequence++;
            }
        }
    }
}