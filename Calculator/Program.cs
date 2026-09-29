CalculatorApp();

void CalculatorApp()
{
    // Declare the variables and initialise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    // Ask the user to input the first number.
    Console.WriteLine("Please enter the first number to be added:, then press Enter");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Display menu.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    // Store the user's choice.
    choice = Convert.ToInt32(Console.ReadLine());

    // Ask for second number.
    Console.WriteLine("Please enter the second number to be added:, then press Enter");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //Usw an IF statement to do the math.
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} gives you {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} gives you {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} and {secondNumber} gives you {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} gives you {result}");
    }
    else
    {
        Console.WriteLine("You did not choose a valid option between 1 and 4");
    }



}