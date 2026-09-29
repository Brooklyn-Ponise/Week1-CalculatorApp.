//Variable names should be short yet meaningful.
//The choice of a variables name should be mnemonic- that is,
//designed to incicate to the reader the intent of its use.

//This intger variable stores the first number to be added.
//Ask the user to input the first number to be added.
Console.WriteLine("Please enter the first number to be added:, then press Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//This integer variable stores the second number to be added.
//Ask the user to input the second number to be added.
Console.WriteLine("Please enter the second number to be added:, then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//This result integer variable stores the result of the addition.
//Performs calculation.
int result = firstNumber + secondNumber;

//Outputs the result of the addition to the console.
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
