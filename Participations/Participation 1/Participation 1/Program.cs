Console.WriteLine("Input a number");
double number1 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Input a second number");
double number2 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Input a third number");
double number3 = Convert.ToDouble( Console.ReadLine() );

double numbersum = number1+number2+number3;
Console.WriteLine("Total sum is " + numbersum);

const double NUMBER = 7.777;

double multipliednumber = numbersum * NUMBER;
Console.WriteLine("Multiplied sum is " + multipliednumber.ToString("0.000"));