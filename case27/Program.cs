/* Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i < num; num /= 10)
    {
        sum = sum + (num % 10);
    }
    Console.Write(sum);
}

int number = InputNum("Введите число: ");
SumNumbers(number);