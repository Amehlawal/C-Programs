string strSource = "";
int nCount = 0;

Console.WriteLine("Please enter the string : ");

strSource = Console.ReadLine();

foreach(char c in strSource)
{
    nCount = nCount + 1;
}

Console.WriteLine("{0} length is {1} ", strSource, nCount.ToString());
Console.ReadLine();