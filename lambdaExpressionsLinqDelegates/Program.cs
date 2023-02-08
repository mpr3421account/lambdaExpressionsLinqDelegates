/*Fazer um programa que, a partir de uma lista de produtos, aumente o
preço dos produtos em 10%..*/

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

        list.ForEach(UpdatePrice);
        foreach(Product p in list)
        {
            Console.WriteLine(p);
        }


    }
    static void UpdatePrice(Product p)
    {
        p.Price += p.Price * 0.1;
    }
}