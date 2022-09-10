// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int MakePositive(int arg)
{
    return arg = arg *-1;
}


System.Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
num = MakePositive(num);
int sum = 0;
while(num>0)
{
    sum = sum + num%10;
    num = num/10;
}
System.Console.WriteLine($"Сумма цифр в вашем числе = {sum}.");