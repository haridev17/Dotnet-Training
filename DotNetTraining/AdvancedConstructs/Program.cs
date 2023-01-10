using System.Globalization;


Console.Write("enter number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition: {a + b}");
}
Add(num1, num2);
Add(1, 3);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if (c > largest)
    {
        c = largest;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is {largest}");

//concatination

string firstName = "Black";
string lastName = "Squad";


string fullName = firstName + " " + lastName;

// Length of a string

int length = fullName.Length;
Console.WriteLine($"First name has  {length} letters");

//Replace string parts
string newFirstName = firstName.Replace("Squad", "SQUAD");
Console.WriteLine($"New first Name is {newFirstName}");

//spilt
string toSplit = "Hari, jenu, asif, savanth, abhijith";
string[] names = toSplit.Split(',');
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

//compare

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullDtring is empty or null");
}
if (string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("nullDtring is empty or null");
}
int res = firstName.CompareTo(lastName);

if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstname and lastname are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}


//DateTime related functionality

// Empty DateTime

DateTime date = new DateTime();

// Create DateTime from data

DateTime dateOfBirth = new DateTime(1886, 1, 7 );
Console.WriteLine($"Date of Birth is {dateOfBirth}:");

//Create DteTime from string

DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");

// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Current time is {now.Ticks}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

// Dateonly

DateOnly dob = DateOnly.FromDateTime(dateOfBirth);

// TimeOnly

TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine(tob);


//exception

Console.Write("Enter number 1: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num4 = Convert.ToInt32(Console.ReadLine());
try
{
    double quotient = num3 / num4;
    Console.WriteLine($"result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Excited the program");
}

// Arrays
// initialised a fixed size array
int[] marks = new int[5]; // 0 besed index (0-4)
// iterate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks :");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}
//print an array of elements
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
string[] usernames = new string[] { "John", "Jake", "jobe" };
// Lists
List<string> devs = new List<string>();
string dev = string.Empty;
while (!dev.Equals("-1"))
{
    Console.Write("Enter the name of the develepor: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}
foreach (string name in devs)
{
    Console.WriteLine(name);
}
