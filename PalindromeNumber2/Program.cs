int num, temp, revNum = 0, rem;

Console.WriteLine("Enter a number : ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;//121

while(num > 0)
{
    rem = num % 10;
    revNum = revNum * 10 + rem;
    num = num / 10;
}
if (num == revNum)
{
    Console.WriteLine("Palindrome Number");
}
else
    Console.WriteLine("Not a Palindrome Number");
Console.ReadLine();