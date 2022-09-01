// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12

Console.Write("Введите число = ");
int A = Convert.ToInt32(Console.ReadLine());

int Sum = SumNumbers(A);
Console.Write ("Сумма цифр в числе " + A + " = " );
Console.WriteLine(Sum);

int SumNumbers (int A)
{
    int count = Convert.ToString(A).Length;
    int result = 0;
    int res = 0;

    for (int i=0; i<count; i++)
    {
       res = A - A % 10;
       result = result + (A - res);
       A = A /10;
    }
    return result;
}

