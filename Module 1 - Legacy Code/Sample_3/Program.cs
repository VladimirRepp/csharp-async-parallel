using Sample_3.Legacy;
using Sample_3.Refactored;

// Задание: 
// Wrap Method - Оборачивание старого метода в новый,
// чтобы добавить новую функциональность 
//
// Метод LegacyFileWriter.Write пишет данные в файл. 
// Оборачивание его, чтобы добавить проверку 
// существования директории и логирование.

// Было
LegacyFileWriter legacyFileWriter = new();
legacyFileWriter.Write("test_legacy_writer.txt", "Тест записи legacy кода...");

// Стало:
SafeFileWriter safeFileWriter = new();
safeFileWriter.Write("test_safety_writer.txt", "Тест записи safety кода...");

