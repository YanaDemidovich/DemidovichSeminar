// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input three number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n1 > max) max = n1;
if(n2 > max) max = n2;
if(n3 > max) max = n3;

    Console.WriteLine(max);