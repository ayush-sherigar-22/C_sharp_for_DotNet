namespace DatabaseConnection
{
    public class OracleConnection(string _connectionstring) : DbConnection(_connectionstring)
    {

        protected override void CloseCore()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Connection to Oracle Database closed : ");
        }

        protected override void OpenCore()

        {
            Thread.Sleep(1000);

            Console.WriteLine("Connection to Oracle Database open");
        }

    }

}
