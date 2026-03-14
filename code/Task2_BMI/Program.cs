// See https://aka.ms/new-console-template for more information
Console.WriteLine("H---Введите число---");
int num = Convert.ToDouble(Console.ReadLine());
if (num <= 1)
{
    Console.WriteLine("Отрицательнок число");
    return;
}
int i = 2;
while (i * i <= n)
    {
        if (n % i == 0)
        {
            return false;
        }
        i = i + 1;
    }
    return true;
