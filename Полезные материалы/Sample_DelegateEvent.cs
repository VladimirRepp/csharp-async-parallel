using Microsoft.VisualBasic.FileIO;

class Program
{
    delegate int NumOperationDelegate(int a, int b);

    delegate void LoggerDelegate(string message);
    static event LoggerDelegate OnLogger;

    static void Main()
    {
        // Подписка на событие
        OnLogger += HandlerConsoleLogger;
        OnLogger += HandlerWinFormLogger;
        OnLogger += HandlerWebLogger;

        int a = 10, b = 23;
        int a1 = 10, b1 = 23;

        int result = RunNumOperation(a, b, Sum);
        OnLogger?.Invoke($"{a} + {b} = {result}");

        int result1 = RunNumOperation(a1, b1, Diff);
        OnLogger?.Invoke($"{a} - {b} = {result}");

        Console.ReadLine();

        // Отписка на событие
        OnLogger -= HandlerConsoleLogger;
        OnLogger -= HandlerWinFormLogger;
        OnLogger -= HandlerWebLogger;
    }

    static int Sum(int a, int b) => (a + b);
    static int Diff(int a, int b) => (a - b);

    static int RunNumOperation(int a, int b, NumOperationDelegate numOperation)
    {
        return numOperation(a, b);
    }

    private static void HandlerConsoleLogger(string message)
    {
        Console.WriteLine(message);
    }

    private static void HandlerWebLogger(string message)
    {
        // TODO: вывод в web интерфейс
    }

    private static void HandlerWinFormLogger(string message)
    {
        // TODO: вывод в WinForm интерфейс
    }
}
