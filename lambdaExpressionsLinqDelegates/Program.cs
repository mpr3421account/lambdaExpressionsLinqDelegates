/*Problema exemplo
Fazer um programa que, a partir de uma lista de produtos, gere uma
nova lista contendo os nomes dos produtos em caixa alta.*/
using System.Collections.Generic;
using lambdaExpressionsLinqDelegates.Entities;

internal class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        Category c1 = new Category(1, "Tools", 2);
        Category c2 = new Category(2, "Computers", 1);
        Category c3 = new Category(3, "Eletronics", 1);

        List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
              };

        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        Print("TIER 1 AND PRICE < 900:", r1);

        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

        var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });//with alias CategoryName
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

        var r5 = r4.Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

        var r6 = products.FirstOrDefault();
        Console.WriteLine("First or Default Test 1: " + r6);
        var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        Console.WriteLine("First or Default Teste 2: " + r7);//retorna null
        Console.WriteLine();

        var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine("Single or Default test 1: " + r8);
        var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine("Single or Default test 2: " + r9);//retorna null
        Console.WriteLine();

        var r10 = products.Max(p => p.Price);
        Console.WriteLine("Max Price: " + r10);
        var r11 = products.Min(p => p.Price);
        Console.WriteLine("Min Price: " + r11);
        Console.WriteLine();

        var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        Console.WriteLine("Category 1 sum prices: " + r12);
        Console.WriteLine();

        var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
        Console.WriteLine("Category 1 average prices: " + r13);
        Console.WriteLine();

        var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();//selecionando preço para gerar a média, porém resolvendo a questão de divisão por 0 caso o collection esteja vazio ou não exista, substituindo o valor pelo argumento 0.0 dado na função
        Console.WriteLine("Category 5 average prices: " + r14);
        Console.WriteLine();

        var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
        Console.WriteLine("Category 1 aggregate sum: " + r15);
        var r15b = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("Category 1 aggregate sum: " + r15b);//caso a coleção onde haverá a soma do aggregate esteja vazia ou não existe, assumirá o valor inicia 0.0
        Console.WriteLine();

        var r16 = products.GroupBy(p => p.Category);
        foreach(IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine("Category: " + group.Key.Name + ":");
            foreach(Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

    }
}