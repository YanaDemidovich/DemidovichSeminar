// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2)
{
    Console.WriteLine(n1 + " " + "min");
    Console.WriteLine(n2 + " " + "max");
}
else
{
        Console.WriteLine(n2 + " " + "min");
        Console.WriteLine(n1 + " " + "max");
}