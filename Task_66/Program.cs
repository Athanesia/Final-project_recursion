//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNumbers(int begin, int end)
{
    if (end == begin) return begin;
    return end + NaturalNumbers(begin, end - 1);
}


Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= n) Console.Write("N должно быть больше M");
else Console.WriteLine(NaturalNumbers(m, n));