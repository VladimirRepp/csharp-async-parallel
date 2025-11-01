namespace Sample_1.Refactor
{
    internal class RefactoredReportGenerator
    {
        public string GenerateReport(List<string> data)
        {
            var report = CreateHeader();
            report += AppendBody(data);
            report += AppendFooter(data);
            return report;
        }

        private string CreateHeader()
        {
            return "Отчет:\n====================\n";
        }

        private string AppendBody(List<string> data)
        {
            return string.Join("\n", data.Select(item => $"Элемент: {item}")) + "\n";
        }

        private string AppendFooter(List<string> data)
        {
            var footer = "====================\n";
            footer += $"Всего элементов: {data.Count}\n";

            if (IsDataLarge(data))
            {
                footer += "ВНИМАНИЕ: Большой объем данных!\n";
            }

            return footer;
        }

        private bool IsDataLarge(List<string> data) => data.Count > 10;

    }
}
