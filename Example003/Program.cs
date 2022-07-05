// Вывести последнюю цифру трехзначного числа

int num, result;

Console.Write("Введите 3-значное число: ");
num = Convert.ToInt32(Console.ReadLine());

result = num % 10;

Console.WriteLine(result);