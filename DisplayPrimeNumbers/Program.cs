Console.WriteLine("Please Enter desired max number to display prime numbers: ");
int nMaxNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Prime numbers {0} and {1} are : ", 2, nMaxNumber);

bool isPrimeNumber = true;

for  (int i = 2; i < nMaxNumber; i++)
{
    for (int j = 2; j< nMaxNumber; j++)
    {
        if (i != j && i % j == 0)
        {
            isPrimeNumber = false; break;
        }
    }
    if (isPrimeNumber)
    {
        Console.WriteLine(i);
    }
    isPrimeNumber = true;
}

Console.ReadLine();