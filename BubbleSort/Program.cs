
int[] UnorderedNumbers = { 30, 10, -90, -40, 50, 25, 70, -54, -80, 38 };

int nTemp = 0;

Console.WriteLine("Sorted Numbers are : ");

for (int i = 0; i < UnorderedNumbers.Length; i++)
{
    for (int j = i + 1; j < UnorderedNumbers.Length; j++)
    {
        if (UnorderedNumbers[i] > UnorderedNumbers[j])
        {
            nTemp = UnorderedNumbers[j];
            UnorderedNumbers[j] = UnorderedNumbers[i];
            UnorderedNumbers[i] = nTemp;
        }
    }
    Console.WriteLine(UnorderedNumbers[i]);
        
}

Console.ReadLine();