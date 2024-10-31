string str, revString = "";

Console.WriteLine("Enter string : ");

str = Console.ReadLine();

str = str.ToLower();
Console.WriteLine(str.Length);
for (int i =str.Length - 1; i >= 0; i--)
{
    revString = revString + str[i];
}

Console.WriteLine("Reverse string is {0}", revString);
Console.ReadLine();