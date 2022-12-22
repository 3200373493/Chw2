/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Введите число необходимого для вас дня ->");
int day = int.Parse(Console.ReadLine ());
int RDay=0;
if (day<=5) 
{
    Console.Write ("Будний день((((((");
} 
if (day>5)
{
 RDay=day%7;
if (RDay==1||RDay==2||RDay==3||RDay==4||RDay==5) 
{
    Console.Write ("Будни((((((");
} 
if (RDay==6||RDay==0)
{
    Console.Write ("_________ВЫХОДНОЙ)))_________");
} 
}