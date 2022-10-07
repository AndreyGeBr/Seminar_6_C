// Программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Использовать рекурсию

Console.Clear();
 
Console.Write("Введите число: ");
int a = Math.Abs(int.Parse(Console.ReadLine()!));
//CountDigits (a);
Console.WriteLine($"Количество цифр в числе {a} равно {CountDigits(a)}");

Console.WriteLine($"Количество цифр в числе {a} равно {CountDigits2(a)}");

int CountDigits(int number, int counter = 0)
{
    if (number / 10 == 0)
    {
        return counter + 1;
    }
    else
    {
        return counter + CountDigits(number / 10) + 1;
    }
}

int CountDigits2(int number)
{
    if (number / 10 < 1) return 1;
    else return CountDigits2(number / 10) + 1;
}