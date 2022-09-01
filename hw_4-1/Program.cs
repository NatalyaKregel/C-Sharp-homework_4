// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵),  2, 4 -> 16 

Console.Write("Введите число А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа B = ");
int B = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(A,B); 
Console.Write ("Число " + A + " в степени " + B + " = ");
Console.WriteLine(exponentiation);

int Exponentiation (int A, int B)
{
    int result = 1;
    for (int i=1; i<=B; i++)
    {
       result = result*A;
    }
    return result;
}

