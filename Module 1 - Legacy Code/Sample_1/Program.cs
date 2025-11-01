using Sample_1.Legacy;
using Sample_1.Refactor;

// Задание:
// Рефакторинг "Метод-монстр" 
// В классе ReportGenerator есть метод GenerateReport, 
// который делает слишком многое. 
// Разбейте его на более мелкие методы с понятными названиями.

// Было
Console.WriteLine("--- Было ---");

ReportGenerator reportGenerator = new();
var report = reportGenerator.GenerateReport(new List<string> { "Данные №1", "Данные №2", "Данные №3" }); ;
Console.WriteLine(report);

// Стало
Console.WriteLine("\n--- Стало ---");

RefactoredReportGenerator refactoredReportGenerator = new();
var refactoredReport = refactoredReportGenerator.GenerateReport(new List<string> { "Данные №1", "Данные №2", "Данные №3" }); ;
Console.WriteLine(refactoredReport);


