/*Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, remova da
lista somente aqueles cujo preço mínimo seja 100.*/

using lambdaExpressionsLinqDelegates.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        list.RemoveAll(ProducTest);
        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }
    public static bool ProducTest(Product p) { return p.Price >= 100.0; }
}