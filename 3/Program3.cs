// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int cube = Calculate(i);
    Console.Write(cube + " ");
}


static int Calculate(int number)
{
    return  number * number * number;
}