Console.WriteLine("--- КАЛЬКУЛЯТОР ---");
            
    while (true)
    {
        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Выход");
        Console.Write("Ваш выбор: ");
        
        string num = Console.ReadLine();
        
        if (num == "5")
        {
            Console.WriteLine("пока");
            break;
        }
        
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        double result = 0;
    
        switch (num)
        {
            case "1":
                result = Add(num1, num2);
                Console.WriteLine($"Результат сложения: {num1} + {num2} = {result}");
                break;
                
            case "2":
                result = Subtract(num1, num2);
                Console.WriteLine($"Результат вычитания: {num1} - {num2} = {result}");
                break;
                
            case "3":
                result = Multiply(num1, num2);
                Console.WriteLine($"Результат умножения: {num1} * {num2} = {result}");
                break;
                
            case "4":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно!");
                    validOperation = false;
                }
                else
                {
                    result = Divide(num1, num2);
                    Console.WriteLine($"Результат деления: {num1} / {num2} = {result}");
                }
                break;
        }
        
    }
    
static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    return a / b;
}