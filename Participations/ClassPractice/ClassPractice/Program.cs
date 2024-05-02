double response = GetDoubleInputFromUser("Please enter your gpa. >>");

double response2 = GetDoubleInputFromUser("Please the square feet of your apartment. >>");

double GetDoubleInputFromUser(string msg)
{
	double ans = 0;
	do
	{
		Console.WriteLine(msg);
		string answer = Console.ReadLine();
		bool ISTrue = double.TryParse(answer, out ans);
	} while (false);
	return ans;
}

double calc(double a1)
	{
		double sum = a1 * 5;
		return sum;
}
Console.WriteLine($"The solution to {response} * 5 = {calc(response)}");
Console.WriteLine($"The solution to {response2} * 5 = {calc(response2)}");



