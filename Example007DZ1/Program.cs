// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int n1 = 4;
int n2 = -3;
int n3 = 7;


int result1 = n1 % 2;
int result2 = n2 % 2;
int result3 = n3 % 2;


if (result1 == 0)
{
    Console.WriteLine(n1 + " " + "четное");
}
else
{
    Console.WriteLine(n1 + " " + "не четное");
}

if (result2 == 0)
{
    Console.WriteLine(n2 + " " + "четное");
}
else
{
    Console.WriteLine(n2 + " " + "не четное");
}

if (result3 == 0)
{   
    
    Console.WriteLine(n3 + " " + "четное");
}
else
{
    Console.WriteLine(n3 + " " + "не четное");
}
