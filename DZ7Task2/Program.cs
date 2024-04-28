// Задача 2: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    // Console.WriteLine("Введите значение m:");
    int m = ReadInt("Введите значение m:");

    // Console.WriteLine("Введите значение n:");
    int n = ReadInt("Введите значение n:");

    // int result = A(m, n);
    Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен " + A(m, n));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int A(int m, int n)
{
    // Базовый случай: если m равно 0, возвращаем n + 1
    if (m == 0)
        return n + 1;

    // Если m больше 0 и n равно 0, вызываем рекурсивно функцию A с аргументами m-1 и 1
    if (n == 0)
        return A(m - 1, 1);

    // В остальных случаях вызываем рекурсивно функцию A с аргументами m-1 и A(m, n-1)
    return A(m - 1, A(m, n - 1));
}


Main();

