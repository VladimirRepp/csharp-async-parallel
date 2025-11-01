namespace Sample_3.Legacy
{
    public class LegacyFileWriter
    {
        public void Write(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
