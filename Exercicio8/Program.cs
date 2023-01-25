using static System.Console;

// 8 - Escreva um programa para gerar uma matriz F (N x M). Criar os vetores IMPAR e PAR com a quantidade de
// elementos (ímpares / pares) da matriz.
// Imprimir a matriz e os vetores. Validar para caso não haja uma das duas possibilidades 
// (sem elementos pares ou ímpares).

int rows = 5;
int columns = 6;

var array = new int[rows, columns];
// array[0, 0] = 10;
// array[0, 1] = 12;
// array[1, 0] = 14;
// array[1, 1] = 24;

var myArray = new MyArray();

myArray.GenerateElements(array);
myArray.ValidateArrays(array);
myArray.Print(array);

System.Console.WriteLine("-------------------------------");

myArray.CreateOddArray(array);
myArray.CreateEvenArray(array);

System.Console.WriteLine("-------------------------------");

myArray.PrintOddArray();

System.Console.WriteLine("-------------------------------");

myArray.PrintEvenArray();

// -------------------

public class MyArray
{
    public bool OddValueExists { get; set; }
    public bool EvenValueExists { get; set; }
    public int[]? OddArray { get; set; }
    public int[]? EvenArray { get; set; }

    public int[,] GenerateArrayBidimensional(int row, int column)
    {
        var matriz = new int[row, column];

        return matriz;
    }

    public void GenerateElements(int[,] matriz)
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

    private void CopyElementsForOddArray(int[,] matriz)
    {
        var oddArrayPosition = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                var value = matriz[i, j];
                if (value % 2 > 0)
                {
                    OddArray![oddArrayPosition] = value;
                    oddArrayPosition++;
                }
            }
        }
    }

    private void CopyElementsForEvenArray(int[,] matriz)
    {
        var evenArrayPosition = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                var value = matriz[i, j];
                if (value % 2 == 0)
                {
                    EvenArray![evenArrayPosition] = value;
                    evenArrayPosition++;
                }
            }
        }
    }

    public void CreateOddArray(int[,] matriz)
    {
        if (OddValueExists == false)
        {
            WriteLine("Nao existe um valor impar na matriz, por isso nao criamos um vetor impar.");
            return;
        }

        var totalOddElements = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                var value = matriz[i, j];
                if (value % 2 == 1)
                {
                    totalOddElements++;
                }
            }
        }
        OddArray = new int[totalOddElements];
        CopyElementsForOddArray(matriz);
    }

    public void CreateEvenArray(int[,] matriz)
    {
        if (EvenValueExists == false)
        {
            WriteLine("Não existe um valor par na matriz, por isso não criamos um vetor par.");
            return;
        }

        var totalEvenElements = 0;

        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                var value = matriz[i, j];
                if (value % 2 == 0)
                {
                    totalEvenElements++;
                }
            }
        }
        EvenArray = new int[totalEvenElements];
        CopyElementsForEvenArray(matriz);
    }

    public void ValidateArrays(int[,] matriz)
    {
        OddValueExists = ValidateOddValueInTheArrayBidimensional(matriz);
        EvenValueExists = ValidateEvenValueInTheArrayBidimensional(matriz);
    }

    public bool ValidateOddValueInTheArrayBidimensional(int[,] matriz)
    {
        var totalOddElements = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                int value = matriz[i, j];

                if (value % 2 != 0)
                    totalOddElements++;
            }
        }

        if (totalOddElements > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ValidateEvenValueInTheArrayBidimensional(int[,] matriz)
    {
        var totalEvenElements = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                int value = matriz[i, j];

                if (value % 2 == 0)
                    totalEvenElements++;
            }
        }

        if (totalEvenElements > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print(int[,] matriz)
    {
        var sequence = 1;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                WriteLine($"Sequencia {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i, j]}");
                sequence++;
            }
        }
    }

    public void PrintOddArray()
    {
        if (OddValueExists == false)
            return;

        var position = 1;
        WriteLine("Valores do array impar que estavam na matriz multidimensional.");
        for (int i = OddArray!.GetLowerBound(0); i <= OddArray.GetUpperBound(0); i++)
        {
            WriteLine($"Posição: {position}, Valor: {OddArray[i]}");
            position++;
        }
    }

    public void PrintEvenArray()
    {
        if (EvenValueExists == false)
        {
            return;
        }

        var position = 1;
        WriteLine("Valores do Array par que estavam na matriz multidimensional.");
        for (int i = EvenArray!.GetLowerBound(0); i <= EvenArray.GetUpperBound(0); i++)
        {
            WriteLine($"Posição: {position}, Valor: {EvenArray[i]}");
            position++;
        }
    }
}