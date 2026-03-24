namespace DatabaseConnection
{
    public class OracleComand : DbCommand
    {
        public OracleComand(DbConnection connection, string command)
            :base(connection, command) { }
       
    }

}
