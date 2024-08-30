using Sales_Receipts;

Dictionary<int, List<Receipt>> receipts = new Dictionary<int, List<Receipt>>();
string answer;

do
{

    int cogs = ValidateIntegerInput("Enter the Quantity of Cogs", "Sorry that is invalid. Please enter a valid value");

    int gears = ValidateIntegerInput("Enter the Quantity of Gears", "Sorry that is invalid. Please enter a valid value"); ;

    int id = ValidateIntegerInput("Enter the customers ID", "Sorry that is invalid. Please enter a valid value"); ;

    Receipt receipt = new Receipt(id, cogs, gears);

    if (receipts.ContainsKey(id) == false)
    { 
        receipts.Add(id, new List<Receipt>());
    }
    receipts[id].Add(receipt);

    Console.WriteLine("Do you want to enter information for another receipt? (yes/no)");
    answer = Console.ReadLine();
} while (answer.ToLower() == "yes");

do
{
    DisplayOptions();
    answer = Console.ReadLine();
    int choice = 0;
    while (int.TryParse(answer, out choice) == false || choice !=3 && choice != 2 && choice != 1)
    {
        Console.WriteLine($"{answer} was not a valid input. Please look at menu and input a number between 1 and 3");
        DisplayOptions();
        answer = Console.ReadLine();
    }

    switch (choice)
    {
        case 1:
            int id = ValidateIntegerInput("Please enter the customer ID that you want to see receipts from.", "Sorry, that was not a valid cutomer ID");
            DisplayReceiptsByCustomerID(receipts, id);
            break;
        case 2:
            DisplayReceiptsForToday(receipts);

            break;    
        case 3:
            DisplayReceiptsWithHighestTotal(receipts);

            break;
    }

    Console.WriteLine("Do you want to display more receipts? (yes/no)");
    answer = Console.ReadLine();
} while (answer.ToLower() == "yes");

Console.WriteLine("Goodbye");

void DisplayReceiptsWithHighestTotal(Dictionary<int, List<Receipt>> receipts)
{
    double highest = -1;

    foreach (var customer in receipts.Keys)
    {
        foreach (var receipt in receipts[customer])
        {
            if (receipt.CalculateTotal() > highest)
            {
                highest = receipt.CalculateTotal();
            }
        }
    }

    foreach (var customer in receipts.Keys)
    {
        foreach (var receipt in receipts[customer])
        {
            if (receipt.CalculateTotal() == highest)
            {
                receipt.PrintReceipt();
            }
        }
    }
}

void DisplayReceiptsForToday(Dictionary<int, List<Receipt>> receipts)
{
    foreach (var customer in receipts.Keys)
    {
        foreach (var receipt in receipts[customer])
        {
            if (receipt.SaleDate.Date == DateTime.Now.Date)
            {
                receipt.PrintReceipt();
            }
        }
    }
}

void DisplayReceiptsByCustomerID(Dictionary<int, List<Receipt>> receipts, int id)
{
    if (receipts.ContainsKey(id) == false)
    {
        Console.WriteLine($"Sorry, there are no receipts for a customer with id {id}");
    }
    foreach (var receipt in receipts[id])
    {
        receipt.PrintReceipt();
    }
}

static void DisplayOptions()
{
    Console.WriteLine("".PadRight(15, '#'));
    Console.WriteLine("\tOptions");
    Console.WriteLine("1. By CustomerID");
    Console.WriteLine("2. All of todays Receipt's");
    Console.WriteLine("3. Receipt with highest total");
    Console.WriteLine("".PadRight(15,'#'));
    Console.WriteLine();
}
static int ValidateIntegerInput(string initialMessage, string rePromptMessage)
    {
    int value;
    string input;
    Console.WriteLine(initialMessage);
    input = Console.ReadLine();
    while (int.TryParse(input, out value) == false)
    {
        Console.WriteLine(rePromptMessage);
        input = Console.ReadLine();
    }
    return value;
}