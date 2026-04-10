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
}







