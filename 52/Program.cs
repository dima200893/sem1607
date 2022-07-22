int m = InputInt("Введите количество строк");
int n = InputInt("Введите количество столбцов");
double a = 0;
string result = String.Empty;
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
SredneeArif(numbers);

void SredneeArif(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            a += array[j, i];
        }
        double srednee = Math.Round(a / m,2);
        a = 0;
        result += srednee + " ";
    }
    Console.WriteLine("Среднее арифметичское каждого столбца : "+result);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}