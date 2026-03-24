namespace DatabaseConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbConnection sql = new SQLConnection("Server=.;Database=TestDb;");
            DbCommand sqlcommand = new SqlCommand(sql, "Select");
            sqlcommand.Execute();

            DbConnection oracle = new OracleConnection("Server : Database = OracleTest");
            DbCommand oraclecommand = new OracleComand(oracle, "Select");
            oraclecommand.Execute();
        }
    }

}
