/*Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, gere uma
nova lista contendo os nomes dos produtos em caixa alta.*/

using lambdaExpressionsLinqDelegates.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));


        Func<Product, string> func = NameUpper;//utilizando delegate com Func recebendo Product e retornando string - Recebendo a referência NameUpper

        List<string> result = list.Select(func).ToList();//alterado o parâmetro para func no Select
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
    static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }
}