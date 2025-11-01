using Sample_3.Legacy;

namespace Sample_3.Refactored
{
    public class SafeFileWriter
    {
        private readonly LegacyFileWriter _legacyWriter;

        public SafeFileWriter()
        {
            _legacyWriter = new LegacyFileWriter();
        }

        public SafeFileWriter(LegacyFileWriter legacyFileWriter)
        {
            _legacyWriter = legacyFileWriter;
        }

        public void Write(string path, string content)
        {
            // Новая функциональность ДО
            EnsureDirectoryExists(path);
            Log($"Запись в файл: {path}");

            // Вызов старого кода
            _legacyWriter.Write(path, content);

            // Новая функциональность ПОСЛЕ
            Log($"Файл успешно записан: {path}");
        }

        private void EnsureDirectoryExists(string filePath)
        {
            var dir = Path.GetDirectoryName(filePath);

            if(string.IsNullOrEmpty(dir))
            {
                dir = Directory.GetCurrentDirectory();
            }

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir!);// dir! - "!" утверждение для компилятора, что переменная не null
            }
        }

        private void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

}
