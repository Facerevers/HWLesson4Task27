// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = (sum + num % 10);
        num = num / 10;
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
int sum = GetSum(number);
Console.WriteLine($"{number} -> {sum}");