// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int numM = ReadInt("Введите число M: ");
    int numN = ReadInt("Введите число N: ");
    PrintNumbers(numM, numN);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (N < 1) return;
    if (N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + " ");
}


Main();
