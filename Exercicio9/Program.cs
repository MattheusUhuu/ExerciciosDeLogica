// 9 - Escreva um programa para gerar uma matriz quadrada G de dimensão N. Imprimir os elementos da diagonal
// principal (linha = coluna).

var array = new int[4, 4];

MyArray myArray = new MyArray();

myArray.GenerateElements(array);
//myArray.PrintElements(array);
myArray.PrintMainDiagonalElements(array);

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

    public void PrintElements(int[,] matriz)
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

    public void PrintMainDiagonalElements(int[,] matriz)
    {
        var sequence = 1;
        Console.WriteLine("Diagonal Principal.");
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                i = j;
                Console.WriteLine($"Sequencia {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i, j]}");
                sequence++;
            }
        }
    }
}