using lambdaExpressionsLinqDelegates.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

Comparison<Product> comp = CompareProducts;//varíavel guardando a referência para uma função

list.Sort(comp);//chamando a função CompareProducts - Referência para a Função - Delegate

foreach(Product p in list)
{
    Console.WriteLine(p);
}

static int CompareProducts(Product p1, Product p2)//criado um méthodo auxiliar com a funcão de comparação
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}