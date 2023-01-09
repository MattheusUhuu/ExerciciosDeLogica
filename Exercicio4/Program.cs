// Escreva um programa para ler uma matriz D de dimensão N x M, onde N e M não poderem ser menores que um. Gerar os elementos aleatoriamente.
// O usuário deve informar a dimensão (linha e coluna) e um valor máximo para elementos aleatórios. O programa efetuar todas as validações.
// Lembre-se de aproveitar os recursos da linguagem para facilitar as validações.

bool validArray = false;
int columns = 0;
int rows = 0;
int maxValueForElements = 0;

while (validArray != true)
{
    Console.WriteLine("Informe o tamanho das linhas e colunas da matriz: ");
    Console.Write("Linha: ");
    rows = int.Parse(Console.ReadLine()!);
    Console.Write("Colunas: ");
    columns = int.Parse(Console.ReadLine()!);

    Console.Write("Informe o valor maximo para os elementos gerados aleatoriamente: ");
    maxValueForElements = int.Parse(Console.ReadLine()!);

    if (rows < 1 || columns < 1)
        validArray = false;
    else
        validArray = true;
}

var matrizD = new int[rows, columns];

Elements.GenerateElements(ref matrizD, maxValueForElements);
Elements.PrintElements(matrizD);


// ------------------------------------------

public static class Elements
{
    public static void GenerateElements(ref int[,] matriz, int maxValueForElements)
    {
        for (int i = matriz.GetLowerBound(0); i < matriz.GetLongLength(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j < matriz.GetLongLength(1); j++)
            {
                Random random = new Random();

                matriz[i,j] = random.Next(maxValueForElements);
            }
        }
    }

    public static void PrintElements(int[,] matriz)
    {
        var sequence = 1;
        for (int i = matriz.GetLowerBound(0); i < matriz.GetLongLength(0); i++)
        {
            for (int j = matriz.GetLowerBound(1); j < matriz.GetLongLength(1); j++)
            {
                Console.WriteLine($"Sequencia: {sequence}, Linha: {i}, Coluna: {j}, Valor: {matriz[i,j]}");
                sequence++;
            }
        }
    }
}