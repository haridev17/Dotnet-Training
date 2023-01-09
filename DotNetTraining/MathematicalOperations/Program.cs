int num1 = 10;
int num2 = 20;



Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction:{num2 - num1}");
Console.WriteLine($"Division:{num2 / num1}");
Console.WriteLine($"Multiplication:{num2 * num1}");
Console.WriteLine($"Modulus:{num2 % num1}");



num1 = num1 + 4;



Console.WriteLine($"New value for num1:{num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction:{num2 - num1}");
Console.WriteLine($"Division:{num2 / num1}");
Console.WriteLine($"Multiplication:{num2 * num1}");
Console.WriteLine($"Modulus:{num2 % num1}");



num1 += 4;



Console.WriteLine($"New value for num1 after +={num1}");
num1 -= 4;
Console.WriteLine($"New value for num1 after -={num1}");
num1 *= 4;
Console.WriteLine($"New value for num1 after *={num1}");
num1 /= 4;
Console.WriteLine($"New value for num1 after /={num1}");
num1 %= 4;
Console.WriteLine($"New value for num1 after %={num1}");
