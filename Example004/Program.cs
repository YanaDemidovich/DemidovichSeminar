// Написать программу, где на входе мы получаем число, а на выходе выводится все целые числа в промежутке от эквивалентного ему отрицательного до положительного

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = n * (-1);

while(current <= n)
{
    Console.Write(current + " ");
    current++; // либо current = current + 1
}
