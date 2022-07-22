int m = InputInt("Введите количетсво строк");
int n = InputInt("Введите количсетво стольбцов");
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);

void PrintArray(double[,] array)
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

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] =Math.Round(new Random().NextDouble() * 100 , 1);        
        }
    }
}


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}