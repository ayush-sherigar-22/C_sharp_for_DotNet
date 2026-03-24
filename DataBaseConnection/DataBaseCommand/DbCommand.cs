namespace DatabaseConnection
{
    public abstract class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _command;

        protected DbCommand(DbConnection connection, string command)
        {
            if(connection == null)
            {
                throw new ArgumentNullException("Connection string or Command is null");
            }
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("Invalid Command");
            }
            this._connection = connection; 
            _command = command;
            
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Thread.Sleep(1000);
            Console.WriteLine("Executing the command {0}", _command);
            Thread.Sleep(1000);
            _connection.CloseConnection();
        }
    }

}
