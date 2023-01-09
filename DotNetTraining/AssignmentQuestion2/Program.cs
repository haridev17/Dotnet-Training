
int a = 0;
int b = 0;
int c = 0;
double equation = 0.0;

Console.Write("Enter value of a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of c: ");
c = Convert.ToInt32(Console.ReadLine());

equation = (((a + b) / c) * a);

Console.WriteLine($"(((a + b) / c) * a) : {equation}");