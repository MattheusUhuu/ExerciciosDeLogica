/* 17 - Escreva um programa para gerar uma matriz quadrada Q de dimensão N. 
Imprimir os elementos da acima da diagonal principal (inclusa) e abaixo da diagonal secundária (inclusa).
*/

/*
Colunas  0  1  2  3  4  5
Linhas 0 14 28 85 12 34 47
       1 93 42 38 97 42 39
       2 38 40 23 40 92 38 
       3 37 19 34 75 91 56 
       4 17 82 95 47 16 45 
       5 91 63 46 59 17 50 
       acima da Diagonal Principal: 28, 38, 40, 91, 45
       abaixo da diagonal Secundaria: 39, 92, 75, 95, 63
*/
using static System.Console;


var dimensionN = 6;

var array = new int[dimensionN, dimensionN];

var myArray = new MyArray();

myArray.PopulateArrayToTest(array);
myArray.PrintDiagonals(array);

public class MyArray
{
    public void PrintDiagonals(int[,] array)
    {
        PrintTheElementsAboveTheMainDiagonal(array);
        PrintTheElementsBelowTheSecondaryDiagonal(array);
    }

    private void PrintTheElementsBelowTheSecondaryDiagonal(int[,] array)
    {
        WriteLine("---------------------------------------------------------------- \n Valores de teste abaixo da diagonal secundaria: 39, 92, 75, 95, 63");
        for (int i = array.GetLowerBound(0) + 1; i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetUpperBound(1); j > array.GetLowerBound(1); j--)
            {
                WriteLine($"Linha: {i}, Coluna: {j}, Valor: {array[i, j]}");
                i++;
            }
        }
    }

    private void PrintTheElementsAboveTheMainDiagonal(int[,] array)
    {
        WriteLine("---------------------------------------------------------------- \n Valores de teste acima da diagonal principal: 28, 38, 40, 91, 45");
        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
        {
            for (int j = array.GetLowerBound(1) + 1; j <= array.GetUpperBound(1); j++)
            {
                WriteLine($"Linha: {i}, Coluna: {j}, Valor: {array[i, j]}");
                i++;
            }
        }
    }

    public void PopulateArrayToTest(int[,] array)
    {
        array[0, 0] = 14;
        array[0, 1] = 28;
        array[0, 2] = 85;
        array[0, 3] = 12;
        array[0, 4] = 34;
        array[0, 5] = 47;

        array[1, 0] = 93;
        array[1, 1] = 42;
        array[1, 2] = 38;
        array[1, 3] = 97;
        array[1, 4] = 42;
        array[1, 5] = 39;

        array[2, 0] = 38;
        array[2, 1] = 40;
        array[2, 2] = 23;
        array[2, 3] = 40;
        array[2, 4] = 92;
        array[2, 5] = 38;

        array[3, 0] = 37;
        array[3, 1] = 19;
        array[3, 2] = 34;
        array[3, 3] = 75;
        array[3, 4] = 91;
        array[3, 5] = 56;

        array[4, 0] = 17;
        array[4, 1] = 82;
        array[4, 2] = 95;
        array[4, 3] = 47;
        array[4, 4] = 16;
        array[4, 5] = 45;

        array[5, 0] = 91;
        array[5, 1] = 63;
        array[5, 2] = 46;
        array[5, 3] = 59;
        array[5, 4] = 17;
        array[5, 5] = 50;
    }
}