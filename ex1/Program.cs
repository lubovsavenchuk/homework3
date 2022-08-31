// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int WriteNumber = Convert.ToInt32(Console.ReadLine());
int[] number = new int [WriteNumber]; 
int length = number.Length;

if(length == 5)
{
   if (number[0] == number[4] && number[1] == number[3])
   {
      Console.WriteLine("Введенное число - палиндром");
   }
   else
   {
      Console.WriteLine("Введенное число - не палиндром");
   }
}