/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/


Console.WriteLine("введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int b = a;

while (b > 0)
{
int num = b % 10;
b = b / 10;
sum = sum + num;
}
Console.WriteLine(a + " -> " + sum);