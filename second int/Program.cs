/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.Write("Введите число = ");
int N =Convert.ToInt32(Console.ReadLine());
while (N>1000)
{
    N = N/10;    
}
N = N/10%10;
Console.WriteLine($"Вторым числом является = {N}");