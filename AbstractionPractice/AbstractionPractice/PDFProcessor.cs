namespace Abstraction
{
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







