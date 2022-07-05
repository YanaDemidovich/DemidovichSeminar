// Написать программу, которая будет выдавать название дней недели по заданному номеру

int n1;

Console.Write("Input number: ");
n1 = Convert.ToInt32(Console.ReadLine());

if (n1 == 1)
{
    Console.Write("Monday");
}
else
    if (n1 == 2)
{
   Console.Write("Tuesday");
}
else
    if (n1 == 3)
{
    Console.Write("Wednesday");
}
else
    if (n1 == 4)
{
    Console.Write("Thursday");
}
else
    if (n1 == 5)
{
    Console.Write("Friday");
}
else
    if (n1 == 6)
{
    Console.Write("Saturday");
}
else
    if (n1 == 7)
{
    Console.Write("Sunday");
}
else
{
    Console.Write("Error");
}