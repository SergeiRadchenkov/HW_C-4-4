/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16     */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!); 
}

int Degree(int num1, int num2)
{
    int res = num1;
    for (int i = 1; i < num2; i++)
        res = res * num1;
    return res;
}

int a = InputNum("Введите первое число: ");
int b = InputNum("Введите второе число: ");
int result = Degree(a, b);
Console.Write(result);