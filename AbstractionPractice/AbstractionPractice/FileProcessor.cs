namespace Abstraction
{

    public abstract class FileProcessor
    {

        public void Execute()
        {
            Read();
            Process();
            Log("Execution Completed");
        }
        public abstract void Read();
        public abstract void Process();

        public void Log(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }

            Console.WriteLine($"[LOG - {this.GetType().Name}] {message} at {DateTime.Now}");
        }
    }

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

    public class CSVProcessor : FileProcessor
    {
        public override void Read()
        {
            Console.WriteLine($"Reading the CV File");
            Log("Reading CSV File");
        }

        public override void Process()
        {
            Console.WriteLine("Processing CSV File...");

            int rows = 50;
            int columns = 5;

            Console.WriteLine($"Rows: {rows}, Columns: {columns}");

            Log("CSV file processed");
        }

    }


    public class PDFProcessor : FileProcessor
    {
        public override void Read()
        {
            Console.WriteLine($"Reading the PDF File");
            Log("Reading PDF File");
        }

        public override void Process()
        {
            Console.WriteLine("Processing PDF File...");

            int pages = 10;
            Console.WriteLine($"Total Pages: {pages}");

            Log("PDF file processed");

        }
    }


}







