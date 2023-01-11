int balance = 1000;
int options = 0;

void CheckBalance()
{
    Console.WriteLine($"Your balance is:{balance} ");
}

bool CheckCredentials()
{
    int cardNumber = 987654;
    int pin = 0123;
    int inputCardNumber = 0;
    int inputPin = 0;

    Console.WriteLine("Enter Your Card Number ");
    inputCardNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Your Pin Number ");
    inputPin = Convert.ToInt32(Console.ReadLine());

    if (inputCardNumber == cardNumber && pin == inputPin)
    { 
        return true;
    }

    else 
    {
        return false;
    }

}
void ThankYou()
{
    Console.WriteLine("Thank you for using our atm ");
}
void Deposit()
{
    int deposit = 0;
    Console.WriteLine("Enter amount to be deposited ");
    deposit = Convert.ToInt32(Console.ReadLine());
    balance += deposit;
    ThankYou();
    CheckBalance();
}

void Withdrawal()
{
    int withdrawal = 0;
    Console.WriteLine("Enter amount to be withdrawn");
    withdrawal = Convert.ToInt32(Console.ReadLine());
    if (withdrawal > balance)
    {
        Console.WriteLine("You have insufficient balance");
        
    }
    else
    {
       balance -= withdrawal;
    }
    ThankYou();
    CheckBalance();
}

void UserChoice()
{
    
    Console.WriteLine("********Welcome to RBI ATM **************\n");
    Console.WriteLine("Enter your choice");
    Console.WriteLine("1. Check Balance: Press 1\n");
    Console.WriteLine("2. Withdraw Cash: Press 2\n");
    Console.WriteLine("3. Deposit Cash: Press 3\n");
    Console.WriteLine("4. Quit: Press 4\n");
    Console.WriteLine("*********************************************\n\n");
    options = Convert.ToInt32(Console.ReadLine());
}
try
{

    if (CheckCredentials())
    {
        
        while(options != 4)
        {
            UserChoice();
            switch (options)
            {
                case 1:
                    CheckBalance();
                    break;
                case 2:
                    Withdrawal();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    ThankYou();
                    break;
            }
        }


    }
    else
    {
        Console.WriteLine("You have entered wrong atm pin or card number");

    }
}

catch (Exception ex)
{
    Console.WriteLine($"Something went wrong{ex.Message}");
}
