// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите число");
int value = Console.Read();
if (value%7==0 && value%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else 
{
    Console.WriteLine("Число Не кратно 23 и/или 7");
}