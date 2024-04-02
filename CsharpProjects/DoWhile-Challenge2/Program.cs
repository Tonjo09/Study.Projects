string? readResult;
int numValue = 0;
bool validNumber = false;


Console.WriteLine("Enter a integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
        }
    }

    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false);

Console.WriteLine($"Your input ({numValue}) has been accepted");

