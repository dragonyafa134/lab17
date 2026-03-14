Console.WriteLine("Подъем по лестнице");
Console.Write("На какой этаж нужно подниматься ");
int targetFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1;
Console.WriteLine("Начинаем подъем!");

while ( currentFloor < targetFloor)
{
    currentFloor++;
    Console.WriteLine($"Поднялись на {currentFloor}");
}
Console.WriteLine($"Вы достигади {targetFloor}");
Console.WriteLine("Конец программы");