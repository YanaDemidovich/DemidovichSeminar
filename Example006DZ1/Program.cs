// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input three number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine(n1);
}
else
{
    Console.WriteLine(n2);
}