// Программа, которая принимает на вход 2 числа, количество строк и количество столбцо, 
// создаёт матрицу данного размера и заполняет нулями или единицами в случайном порядке и выводит в консоль.
Console.Clear();

Console.Write("Введите количество строк: ");
int row = Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите количество столбцов: ");
int column = Math.Abs(int.Parse(Console.ReadLine()!));

int[,] matrix = new int[row, column];
FillArray(matrix);
PrintArray(matrix);


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"| {matr[i, j]} |");
        }
Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 2);
        }
    }
}


