//basic loops

//do while loop exercise #1 
bool reprintMessage;

do
{
    Console.WriteLine("Hello World");

    Console.WriteLine("Would you like to reprint this message? (y/n)");
    string userResponse = Console.ReadLine();

    if (userResponse.ToLower() == "y")
    {
        reprintMessage = true;
    }
    else
    {
        reprintMessage = false;
    }

} while (reprintMessage == true);

//for loop exercise #2
Console.WriteLine("Enter a number:");

bool continueProgram = true;
string userNumber = Console.ReadLine();
int userGuessAsInt = int.Parse(userNumber);
while (continueProgram == true)
{
    for (int number = userGuessAsInt; number >= 0; number--)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();

    for (int number = 0; number <= userGuessAsInt; number++)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    string input = Console.ReadLine().ToLower();

    if (input != "y")
    {
        Console.WriteLine("Goodbye!");
        continueProgram = false;
    }
}

//Loop exercise #3
string passcode = "13579";
bool isDoorLocked = true;
int userAttempts = 0;
int maxAttempts = 5;

do
{
    Console.WriteLine("Enter the passcode");
    string userCode = Console.ReadLine();

    if (userCode == passcode)
    {
        Console.WriteLine("Welcome! Happy you made it!");
        isDoorLocked = false;
    }
    else
    {
        userAttempts++;
        if(userAttempts < maxAttempts)
        {
            Console.WriteLine($"The code you've enetered is incorrect. You have {maxAttempts - userAttempts} attempts left.");
        }
    }
} while (isDoorLocked && userAttempts < maxAttempts);

if (isDoorLocked)
{
    Console.WriteLine("Too many incorrect attempts. Access denied.");
}


