/*********************************************************************************************************************
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

**********************************************************************************************************************/
int num_N;
int temp = 1;
int[] mass;
int index = 0;

Console.WriteLine("Введите целое число: ");
num_N = int.Parse(Console.ReadLine());
mass = new int[num_N / 2];
while (temp <= num_N)
{
   if (temp % 2 == 0)
    {
        mass[index] = temp;
        index ++;
    }
    temp = temp + 1;
} 
   Console.WriteLine("Вы ввели: " + num_N);
   Console.WriteLine("Все чётные числа от 1 до " + num_N);
   foreach (var item in mass) 
            {
            Console.Write(" "+ item);
            }