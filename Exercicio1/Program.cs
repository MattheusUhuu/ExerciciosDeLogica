using static System.Console;

// Escreva um programa para ler uma matriz A de 4 linhas por 5 colunas e imprimir seus elementos.
int rows = 4;
int columns = 5;

string[,] myArray = new string[rows, columns];

Elements.AddElements(ref myArray);
Elements.PrintElements(myArray);

//--------------------------------------------------------------------------------
public static class Elements
{
    public static void AddElements(ref string[,] array)
    {
        int sequence = 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = $"Sequencia: {sequence} | Linha: {i}. Coluna: {j}";
                sequence++;
            }
        }
    }

    public static void PrintElements(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                WriteLine(array[i, j]);
            }
        }
    }
}

