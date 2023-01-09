//conditional
//if else (==, >, <, >=, <=, !=)



Console.Write("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of oranges");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());



if (numberOfApples > numberOfOranges)
{
    Console.Write("There are more number of apples than oranges: ");
}
else if (numberOfOranges > numberOfApples)
{
    Console.Write("There are more number of oranges than apples: ");
}
else if (numberOfApples == numberOfOranges)
{
    Console.Write("Apples and oranges are equal: ");
}
else
{
    Console.Write("Invalid: ");
}



// switch
Console.WriteLine("Enter your mark(0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());



switch (marks)
{
    case int n when (n < 50):
        Console.WriteLine("You are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("You are passed");
        break;
    default:
        Console.WriteLine("Inalid input for mark");
        break;
}
