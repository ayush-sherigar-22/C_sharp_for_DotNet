namespace DatabaseConnection
{
    public class SqlCommand : DbCommand
    {
        public SqlCommand(DbConnection connection, string command)
         : base(connection, command) { }

    }

}
