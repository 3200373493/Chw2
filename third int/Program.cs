/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите число");
int N =int.Parse(Console.ReadLine());
if (N<100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    int third = N%10;
    Console.WriteLine ($"Третья цифра = {third}");
}