// / Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());


int count = 1;

while(count < N)
{
double num = Math.Pow(count, 3);
Console.Write($"{num}, ");
count++;
}
Console.Write($"{Math.Pow(N, 3)}");
