Console.WriteLine("Выбор одежды  по погоде");
Console.Write("Введите текущую температуру");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp >= 20)
{
    Console.WriteLine("Найденьте легкую одежду");
}
else
{
    Console.WriteLine("Наденьте теплую одежду");
}
Console.WriteLine("Хорошего дня");