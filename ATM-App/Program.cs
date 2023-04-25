using ATM_App;

List<Cardholder> cardholders = new List<Cardholder>();
cardholders.Add(new Cardholder("12345678", 1234, "John", "Deer", 169.32));
cardholders.Add(new Cardholder("23456789", 2345, "Leano", "John", 300.12));
cardholders.Add(new Cardholder("34567891", 3456, "Michael", "Pfister", 102.34));
cardholders.Add(new Cardholder("45678912", 4567, "Lukas", "Frey", 226.87));
cardholders.Add(new Cardholder("56789123", 5678, "Samuel", "Matarese", 250.63));

GUI gui = new GUI();

Console.WriteLine("Welcome to Olivier's ATM");
Console.WriteLine("Please insert your Cardnumber: ");

string cardNumber;
Cardholder currentUser;

while (true)
{
    try
    {
        cardNumber = Console.ReadLine();
        currentUser = cardholders.FirstOrDefault(a => a.cardnumber == cardNumber);

        if (currentUser != null)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cardnumber was not found. Please try again.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Cardnumber was not found. Please try again.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("Please enter your pin: ");
int userPin = 0;

while (true)
{
    try
    {
        userPin = int.Parse(Console.ReadLine());
        if (currentUser.getPin() == userPin)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect pin. Please try again.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect pin. Please try again.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");
int option = 0;

do
{
    gui.printOptions();
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch { }
    if (option == 1)
    {
        gui.Deposit(currentUser);
    }
    else if (option == 2)
    {
        gui.Withdraw(currentUser);
    }
    else if (option == 3)
    {
        gui.Balance(currentUser);
    }
    else if (option == 4)
    {
        break;
    }
    else
    {
        option = 0;
    }
} while (option != 4);
Console.WriteLine("Thank you, have a nice day " + currentUser.getFirstName());