namespace DatabaseConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbConnection sql = new SQLConnection("Server=.;Database=TestDb;");
            sql.OpenConnection();
            sql.CloseConnection();

            DbConnection oracle = new OracleConnection("Server=.;Database=TestDb;");
            oracle.OpenConnection();
            oracle.CloseConnection();

        }
    }

}
