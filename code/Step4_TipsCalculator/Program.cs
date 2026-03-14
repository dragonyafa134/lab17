Console.WriteLine("Калькулятор чаевых");
Console.Write("Введите сумму счета руб: ");

double bill = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите процент чаевыъ ");

double tipPercent = Convert.ToDouble(Console.ReadLine());
double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill * tipAmount;

Console.WriteLine("Результат");
Console.WriteLine($"Сумма счета {bill} руб");
Console.WriteLine($"Чаевых ({tipPercent}) {tipAmount}");
Console.WriteLine($"Итог к оплате {totalAmount}");

Console.WriteLine("Спасибо за использования калькуляторра ");