int number, factorial = 1, i;

Console.WriteLine("Please enter the number to calculate the factorial : ");

number = int.Parse(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Factorials are not applicable for negative number");
}
else if(number == 0)
{
    Console.WriteLine("Factorial of zero is 1");
}
else
{
    for (i = number; i >= 1; i--)
    {
        factorial = factorial * i;
    }
    Console.WriteLine("{0} factorial is  {1}", number.ToString(), factorial.ToString());
}