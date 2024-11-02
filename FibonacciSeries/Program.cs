
int number, previousNumber = -1, nextNumber = 1;

Console.WriteLine("Please enter the number which you would like finacci series ");

number = int.Parse(Console.ReadLine());

Console.WriteLine("Fibonacci Series ");

for (int i = 0; i < number; i++)
{
    int sumNumber = previousNumber + nextNumber;
    Console.WriteLine(sumNumber);
    previousNumber = nextNumber;
    nextNumber = sumNumber;
}

Console.ReadLine();