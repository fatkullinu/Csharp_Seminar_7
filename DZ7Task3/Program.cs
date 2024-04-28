// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenArray(arraySize, 0, 100);

    PrintArray(array, array.Length - 1);
    System.Console.WriteLine();
    PrintArrRev(array, array.Length - 1);
}

void PrintArrRev(int[] arrayForPrint, int i)
{
    if (i < 0) return;
    System.Console.Write(arrayForPrint[i] + " ");
    PrintArrRev(arrayForPrint, i - 1);
}

void PrintArray(int[] arrayForPrint, int i)
{
    if (i < 0) return;
    PrintArray(arrayForPrint, i - 1);
    System.Console.Write(arrayForPrint[i] + " ");
}

int[] GenArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
