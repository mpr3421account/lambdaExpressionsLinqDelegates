using lambdaExpressionsLinqDelegates.Entities;
using lambdaExpressionsLinqDelegates.Services;
List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

//Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));//chamando a função CompareProducts - Referência para a Função - Delegate

foreach(Product p in list)
{
    Console.WriteLine(p);
}



Console.WriteLine();
double a = 10;
double b = 12;

//double result = CalculationService.Square(a);
Console.WriteLine("Delegate: ");

//delegate:
BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;
op(a, b);
Console.WriteLine(op);