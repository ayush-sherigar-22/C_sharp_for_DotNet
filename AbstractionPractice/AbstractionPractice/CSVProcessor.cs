namespace Abstraction
{
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
}







