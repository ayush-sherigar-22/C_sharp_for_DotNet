namespace DatabaseConnection
{
    public class SQLConnection(string _connectionstring) : DbConnection(_connectionstring)
    {
        protected override void CloseCore()
        {

            Thread.Sleep(1000);
            Console.WriteLine("Connection to SQL Database closed : ");
        }

        protected override void OpenCore()
        {

            Thread.Sleep(1000);
            Console.WriteLine("Connection to SQL database opened : ");
        }
    }

}
