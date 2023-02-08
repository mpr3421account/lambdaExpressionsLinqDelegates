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

        Console.WriteLine("Operações do LINQ:");

        Console.WriteLine("Filtering: Where, OfType\r\n• Sorting: OrderBy, OrderByDescending,\r\nThenBy, ThenByDescending, Reverse\r\n• Set: Distinct, Except, Intersect, Union\r\n• Quantification: All, Any, Contains\r\n• Projection: Select, SelectMany\r\n• Partition: Skip, Take\r\n• Join: Join, GroupJoin\r\n• Grouping: GroupBy\r\n• Generational: Empty\r\n• Equality: SequenceEquals\r\n• Element: ElementAt, First, FirstOrDefault\r\nLast, LastOrDefault, Single, SingleOrDefault\r\n• Conversions: AsEnumerable, AsQueryable\r\n• Concatenation: Concat\r\n• Aggregation: Aggregate, Average, Count,\r\nLongCount, Max, Min, Sum");
    }

}