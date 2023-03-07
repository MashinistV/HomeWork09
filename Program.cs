//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.

int ReadInt(string argument)
{
    Console.Write($"Input {argument}");
    int result = 0;

    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("Try again");
    }

    return result;
}

string NatRec(int n)
{
    if (n > 0) return $"{n} " + NatRec(n - 1);
    else return String.Empty;
}

int SumRec(int m, int n)
{
    int sum = 0;

    if (m <= n) return sum = m + SumRec(m + 1, n);
    else return 0;
}

int AckerRec(int m, int n)
{
    // if (m == 0 && n == 0) return 1;
    // else 
    // if (m >= 1) return AckerRec(m - 1, n) + n;
    // else return AckerRec(m, n - 1) + 1;
    while (m > 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = AckerRec(m, n - 1);
        }

        m = m - 1;
    }

    return n + 1;
}

bool isWork = true;

while(isWork)
{
    Console.WriteLine("Choose task 1, 2 or 3. For exit enter '-1'");

    if (int.TryParse(Console.ReadLine(), out int j))
    {
        switch (j)
        {
            case 1:
            {
                Console.Write($"Numbers from entered till one: {NatRec(ReadInt("N = "))}");
                Console.WriteLine();
                break;
            }

            case 2:
            {
                Console.Write($"Sum between theese numbers: {SumRec(ReadInt("M = "), ReadInt("N = "))}");
                Console.WriteLine();
                break;
            }

            case 3:
            {
                Console.Write($"The Ackermann Function: {AckerRec(ReadInt("M = "), ReadInt("N = "))}");
                Console.WriteLine();
                break;
            }

            case -1: isWork = false; break;
        }
    }
}