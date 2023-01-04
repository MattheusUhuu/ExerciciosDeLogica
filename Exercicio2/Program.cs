//Escreva um programa para gerar aleatoriamente os elementos (menor que 100) de uma matriz B de 6 linha por 3 colunas, 
//imprimir a matriz gerada e imprimir a matriz em ordem invertida.

int rows = 6;
int columns = 3;

int[,] matrizB = new int[rows, columns];

Elements.ElementGenerator(ref matrizB);
Elements.PrintElements(matrizB);
Elements.PrintElementsInReverseOrder(matrizB);
// --------------------
public static class Elements
{
    public static void ElementGenerator(ref int[,] matriz)
    {
        Random random = new Random();

        for (int i = matriz.GetLowerBound(0); i < matriz.GetLength(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = random.Next(100);
            }
        }
    }

    public static void PrintElements(int[,] matriz)
    {
        Console.WriteLine();
        
        var sequence = 1;
        for (int i = matriz.GetLowerBound(0); i < matriz.GetLength(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j < matriz.GetLength(1); j++)
            {
                Console.WriteLine($"Sequencia: {sequence}. Valor: {matriz[i,j]}");
                sequence++;
            }
        }
    }

    public static void PrintElementsInReverseOrder(int[,] matriz)
    {
        Console.WriteLine();

        int sequence = matriz.Length;
        for (int i = matriz.GetUpperBound(0); i >= matriz.GetLowerBound(0); i--)
        {
            for (int j = matriz.GetUpperBound(1); j >= matriz.GetLowerBound(1); j--)
            {
                Console.WriteLine($"Sequencia: {sequence}. Valor: {matriz[i,j]}");
                sequence--;
            }
        }
    }
}