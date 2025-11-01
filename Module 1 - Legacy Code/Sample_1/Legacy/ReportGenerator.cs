namespace Sample_1.Legacy
{
    public class ReportGenerator
    {
        public string GenerateReport(List<string> data)
        {
            var result = "Отчет:\n";
            result += "====================\n";

            foreach (var item in data)
            {
                result += $"Элемент: {item}\n";
            }

            result += "====================\n";
            result += $"Всего элементов: {data.Count}\n";

            if (data.Count > 10)
            {
                result += "ВНИМАНИЕ: Большой объем данных!\n";
            }

            return result;
        }
    }

}
