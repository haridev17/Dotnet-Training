//read two input numbers from user
int num1 = 0;
int num2 = 0;

Console.Write("Enter a number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);//sum
Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);//product