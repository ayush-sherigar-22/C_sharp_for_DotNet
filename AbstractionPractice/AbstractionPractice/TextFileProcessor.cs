namespace Abstraction
{
    public class TextFileProcessor : FileProcessor
    {
        public override void Read()
        {
            Console.WriteLine($"Reading the Text File");
            Log("Reading Text File");
        }

        public override void Process()
        {
            Console.WriteLine($"Processing the Text File");
            Console.WriteLine($"Counting the number of words");
            Log("Text File Processed");
        }
    }
}







