using static System.Console;

// 6 - Escreva um programa para gerar aleatoriamente (menor que 25) uma matriz N x M de dimensão definidas pelo
// usuário. Solicitar ao usuário um valor. Imprimir a matriz gerada. Informar se o valor digitado existe
// na matriz, indicando a posição (linha X coluna) e no final a quantidade de ocorrências.

int[,] myArray = MyArrayService.CreateMultidimensionalArray();

MyArrayService.GenerateElementsForThisArray(ref myArray);

MyArrayService.PrintElementsOfThisArray(myArray);

MyArrayService.FindAValueAndPrintYourOccurrences(myArray);

// -----------------------

public static class MyArrayService
{
    public static int[,] CreateMultidimensionalArray()
    {
        Write("Informe o tamanho das linhas: ");
        int rows = int.Parse(ReadLine()!);
        Write("Informe o tamanho das colunas: ");
        int columns = int.Parse(ReadLine()!);
        WriteLine("--------------------------------------------------------------------------");

        var matriz = new int[rows, columns];
        return matriz;
    }

    public static void GenerateElementsForThisArray(ref int[,] matriz)
    {
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                Random random = new Random();
                matriz[i, j] = random.Next(25);
            }
        }
    }

    public static void PrintElementsOfThisArray(int [,] matriz)
    {
        int sequence = 1;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                WriteLine($"Sequencia: {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i,j]}");
                sequence++;
            }
        }
    }

    public static void FindAValueAndPrintYourOccurrences(int[,] matriz)
    {
        Write("Informe o valor que deseja procurar na matriz: ");
        int value = int.Parse(ReadLine()!);

        WriteLine("--------------------------------------------------------------------------");
        int occurrences = 0;
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                if (matriz[i,j].Equals(value))
                {
                    occurrences++;
                    WriteLine($"Valor: {matriz[i,j]}, Linha: {i}, Coluna: {j}");
                }
            }
        }

        if (occurrences == 0)
            WriteLine("Nao encontramos nenhuma ocorrencia nesta matriz do valor informado.");

        if (occurrences > 0)
            WriteLine($"Encontramos {occurrences} ocorrencia(s) desse valor: {value}, nesta matriz");

        WriteLine("--------------------------------------------------------------------------");
    }

}