
//An armstrong number of three digits is an integer such that the sum of the cubes of its digits is equals to the number itself

int num, temp, sum = 0, rem;

Console.WriteLine("Enter a number : ");
num = Convert.ToInt32(Console.ReadLine());
temp = num; //153

while(num > 0)
{
    rem = num % 10; //3
    sum = sum + rem * rem * rem; // 0 + 3 * 3* 3==27
    num = num / 10; //153/10 ==15
}
if (temp == sum)
{
    Console.WriteLine("Armstrong Number");
}
else
{
    Console.WriteLine("Not Armstrong Number");
}
Console.ReadLine();