// Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите число M: "); 
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите M чисел через enter: ");
int[] array = new int[M];
int counter = 0;
 
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
    if (array[i] > 0)
    {
        counter++;
    }
}

if (counter == 1)
{
    Console.WriteLine($"Вы ввели {counter} число больше нуля");
} 
else if (counter == 2 || counter == 3 || counter == 4)
{
    Console.WriteLine($"Вы ввели {counter} числа больше нуля");
}
else
{
    Console.WriteLine($"Вы ввели {counter} чисел больше нуля");
}
