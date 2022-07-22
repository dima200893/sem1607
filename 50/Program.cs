int m = InputInt("Введите количетсво строк");
int n = InputInt("Введите количсетво стольбцов");
int searchNumber=0;
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("введите строку и столбец элемента слитно=");// допсутимый диапазон чисел 0-9
string position = Console.ReadLine();
int a=Convert.ToInt32(position);
int strokaIndex=a/10;
int stolbecIndex=a%10;
FindNumber(numbers);

void FindNumber(int [,]array)
{
    if (strokaIndex<m&&stolbecIndex<n)
    {
        searchNumber=array[strokaIndex,stolbecIndex];
        Console.WriteLine("Введенной позиции соответсвует число=> "+searchNumber);
    }
    else
    {
        Console.WriteLine("Такого числа нет ");
    }
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
            numbers[i, j] = new Random().Next(0,10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}