/*Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, remova da
lista somente aqueles cujo preço mínimo seja 100.*/

using lambdaExpressionsLinqDelegates.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(p => p.Price >= 100.0);
foreach(Product p in list)
{
    Console.WriteLine(p);
}