// Написать программу, где на входе мы получаем число, а на выходе выводится все целые числа в промежутке от эквивалентного ему отрицательного до положительного

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 0)
{
    n = n * (-1);
}

int current = n * (-1);

while(current <= n)
{
    Console.Write(current + " "); // + это склейка символов окружающих его
    current++; // либо current = current + 1
}
