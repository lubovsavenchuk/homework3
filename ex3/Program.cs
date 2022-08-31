// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.

Console.Write("Type any number: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] cubes = new int [N];
int index = 0;
int num = 1;

while (index < N)
{
   cubes[index] = num * num * num;
   Console.Write(cubes[index] + " ");
   num ++;
   index ++;
}