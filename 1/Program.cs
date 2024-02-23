// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



bool IsCorrect (int number)
{
    int check = number;
    int start = 0;

    while (number>0)
    {
        start = start*10 + number%10;
        number /= 10;
    }

    return check == start;
}



Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
if (IsCorrect(num))
{
    Console.WriteLine(num + " Число является палиндромом");
}
else
{
    Console.WriteLine(num + " Число не является палиндромом");
}

