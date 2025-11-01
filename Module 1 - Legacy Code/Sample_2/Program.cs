// Задание:
// Sprout Method - Добавление нового функционала в виде отдельного,
// чистого метода/класса
//
// У вас есть старый метод CalculatePrice, 
// который рассчитывает базовую цену. 
// Не изменяя его, добавьте расчет скидки 10%, 
// если цена больше 1000, используя Sprout Method.

using Sample_2.Legacy;

int quantity = 10; decimal unitPrice = 500;
PriceCalculator priceCalculator = new();
Console.WriteLine("Чек без скидки (legacy code):");
Console.WriteLine($" Количество ({quantity}), Цена за шт ({unitPrice}) = {priceCalculator.CalculatePrice(quantity, unitPrice)}");

Console.WriteLine("\nЧек со скидкой (modified code):");
Console.WriteLine($" Количество ({quantity}), Цена за шт ({unitPrice}) = {priceCalculator.CalculatePriceWithDiscount(quantity, unitPrice)}");
