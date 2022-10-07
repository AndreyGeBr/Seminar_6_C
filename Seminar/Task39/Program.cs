// Программа, которая принимает на вход число А и выдает сумму чисел от 1 до А.
//Использовать рекурсию.

Console.Clear();

Console.Write("Введите число А: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(RecSum(number));

int RecSum(int number)
{
    if (number > 1)
    {
        return number + RecSum(number - 1);
    }
    else
    {
        return 1;
    }
}