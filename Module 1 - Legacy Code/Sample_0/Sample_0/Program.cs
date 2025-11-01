using Sample_0.Legacy_Code;
using Sample_0.Tastable;

// Задание:
// Анализ зависимостей 
// Дан класс OrderProcessor. 
// Найдите в его коде жесткие зависимости, 
// которые мешают тестированию.

// Было:
/*
OrderProcessor orderProcessor = new();
orderProcessor.Process(new Order());
*/

// Стало
MyOrderValidator_1 myOrderValidator_1 = new();
MyOrderValidator_2 myOrderValidator_2 = new();
MyOrderRepository myOrderRepository = new();
MyNotificator_1 myNotificator_1 = new();

TastableOrderProcessor tastableOrderProcessor = new(
    myOrderValidator_1,
    myOrderRepository,
    myNotificator_1
    );
tastableOrderProcessor.Process(new Order());