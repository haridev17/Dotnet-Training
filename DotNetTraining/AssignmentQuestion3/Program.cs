//Fortune Game
int num = 0;
int n = 5;

//Generating random number between 0 and 100
Random rd = new Random();
int random_num = rd.Next(0, 100); 


for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("Enter Your Guess");
    num = Convert.ToInt32(Console.ReadLine());
    int turns = 4 - i;
    Console.WriteLine($" Number of Turns left : {turns}");

    if (random_num == num)
    {
        Console.WriteLine("Yes..! You have won.");
        break;
    }
    if (turns == 0)
    {
        Console.WriteLine("Gameover...!You have lost");
    }
    if (num < random_num)
    {
        Console.WriteLine($"Actual number is greater than {num}");
    }
    else
    {
        Console.WriteLine($"Actual number is lesser than {num}");
    }

}

Console.WriteLine($"The correct number is {random_num}"); // random number
