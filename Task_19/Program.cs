// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите число ");
string str = Console.ReadLine();

int size = str.Length;
int i = 0;
int j = size-1;
if (size>1)
{
    while (i<size/2)
    {
        if (str[i]-'0' == str[j]-'0')
        {
           
            i++;
            j -= 1;
            Console.Clear();
            Console.WriteLine("Введенное число является палиндромом");
        }
        
        else 
        {
            Console.Clear();
            Console.WriteLine("Введенное число не является палиндром");
            break;
        }
    }
}
else 
    {
      Console.WriteLine("Введено число, состоящее из одной цифры. Введите другое число");
    }
