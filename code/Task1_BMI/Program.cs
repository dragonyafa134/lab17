Console.WriteLine("-- КАЛЬКУЛЯТОР ИМТ --");

Console.Write("Введите вес (кг): ");
double ves = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите рост (м): ");
double rost = Convert.ToDouble(Console.ReadLine());

double imt = ves / (rost * rost);

string kategoriya = "";
string sovet = "";

if (imt < 18.5)
{
    kategoriya = "Недостаточный вес";
    sovet = "Нужно лучше питаться";
}
else if (imt < 25)
{
    kategoriya = "Нормальный вес";
    sovet = "Так держать!";
}
else if (imt < 30)
{
    kategoriya = "Избыточный вес";
    sovet = "Больше двигайтесь";
}
else
{
    kategoriya = "Ожирение";
    sovet = "Обратитесь к врачу";
}

Console.WriteLine($"Ваш ИМТ: {imt}");
Console.WriteLine($"Категория: {kategoriya}");
Console.WriteLine($"Совет: {sovet}");