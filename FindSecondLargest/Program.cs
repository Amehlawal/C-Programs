﻿int Max1, Max2;

int[] arr = { 12, 34, 54, 23, 85, 13, 57, 82, 44 };

Console.WriteLine("Array Elements are :");

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i] + " ");
}    

Max1 = Max2 = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > Max1)
    {
        Max2 = Max1;
        Max1 = arr[i];
    }
    else if (arr[i] > Max2)
    {
        Max2 = arr[i];
    }
}
Console.WriteLine("First Max Number : " + Max1);
Console.WriteLine("Second Max Number : " + Max2);

