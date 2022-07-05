// Задача 1. Проверить соответствует ли число n1 квадрату числа n2

int n1, n2, quad;

Console.Write("Input first number: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
n2 = Convert.ToInt32(Console.ReadLine());

quad = n2*n2;

if (quad == n1)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
