string str;
int count = 1, len = 0;

Console.WriteLine("Enter a string : ");
str = Console.ReadLine();

while (len<=str.Length-1)
{
    if(str[len] == ' ' || str[len]=='\n' || str[len]=='\t')
    {
        count++;
    }
    len++;
}
Console.WriteLine("Total No of word(s) "+ count);
Console.ReadLine();