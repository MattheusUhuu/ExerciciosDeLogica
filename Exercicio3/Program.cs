using static System.Console;

// Escreva um programa para ler uma matriz C quadrada de dimensão N, onde N é menor ou igual a 20 e imprimir seus elementos.
// O usuário deve informar o número o tamanho da matriz quadrada (dimensão) e os elementos podem ser gerados aleatoriamente (menor que 100).

int dimensionN = 0;
bool lowerThanTwenty = false;

while(lowerThanTwenty == false)
{
    Write("Informe o tamanho das dimencoes da matriz quadrada (Menor que 20): ");
    dimensionN = int.Parse(ReadLine()!);

    if (dimensionN <= 20 && dimensionN > 0)
        lowerThanTwenty = true;
    
}

var matrizC = new int[dimensionN, dimensionN];

Elements.ElementsGenerator(ref matrizC);
Elements.PrintElements(matrizC);

// -----------------------

public static class Elements
{
    public static void ElementsGenerator(ref int[,] matriz)
    {
        for (int i = matriz.GetLowerBound(0); i <= matriz.GetUpperBound(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j <= matriz.GetUpperBound(1); j++)
            {
                Random random = new Random();

                matriz[i,j] = random.Next(100);
            }    
        }
    }

    public static void PrintElements(int[,] matriz)
    {
        var sequence = 1;
        foreach (var matrizValue in matriz)
        {
            WriteLine($"Sequencia: {sequence}, Valor: {matrizValue}");
            sequence++;
        }
    }
}