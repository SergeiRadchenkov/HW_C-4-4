/* Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(100);
}

/* string PrintArray(int[] ints)
{
    string res = "[ ";
    for (int i = 0; i < ints.Length; i++)
        res += $"{ints[i]} ";
    res += "]";
    return res;
} */

void PrintArray(int[] ints)
{
    Console.Write("[ ");
    for (int i = 0; i < ints.Length - 1; i++)
        Console.Write($"{ints[i]}, ");
    Console.Write($"{ints[ints.Length - 1]} ");
    Console.Write("]");
}

int size = new Random().Next(1, 9);
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
//string answer = PrintArray(myArray);
//Console.WriteLine(answer);
