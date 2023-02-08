/*Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, gere uma
nova lista contendo os nomes dos produtos em caixa alta.*/

using lambdaExpressionsLinqDelegates.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        // Specify the data source.
        int[] numbers = new int[] { 2, 3, 4, 5 };


        // Define the query expression.
        //var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

        IEnumerable<int> result = numbers
        .Where(x => x % 2 == 0)
        .Select(x => 10 * x);


        // Execute the query.
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }

}