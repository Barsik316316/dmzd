Console.WriteLine("Калькулятор Индекса Массы Тела");
Console.WriteLine("Введите ваш вес в килограммах");
double wes = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ваш рост в метрах (например, 1.75):");
double rost = Convert.ToDouble(Console.ReadLine());
double bmi = wes / (rost * rost);
Console.WriteLine($"При весе {wes} кг и росте {rost}м, ваш ИМТ: {bmi}");