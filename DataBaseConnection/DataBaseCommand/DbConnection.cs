using System.Diagnostics;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeOut;
        private bool _status;
        private static readonly TimeSpan _defaultTimeOut = TimeSpan.FromMilliseconds(10000);


        protected DbConnection(String connectionstring)
        {
            if (String.IsNullOrWhiteSpace(connectionstring))
            {
                throw new ArgumentException("Invalid Connection String :");
            }
            _connectionString = connectionstring;
            _timeOut = _defaultTimeOut;
        }

        protected DbConnection(String _connectionString, TimeSpan timeout)
         : this(_connectionString)
        {
            if (timeout == TimeSpan.Zero)
            {
                throw new ArgumentException("Invalid Time provided");
            }
            _timeOut = timeout;

        }



        protected abstract void OpenCore();
        protected abstract void CloseCore();


        public void OpenConnection()
        {

            if (_status)
            {
                throw new InvalidOperationException("Connection is already open : ");
            }
            var connectionTime = Stopwatch.StartNew();

            OpenCore();
            connectionTime.Stop();

            if (connectionTime.Elapsed > _timeOut)
            {
                throw new TimeoutException("Connection Timed out");
            }

            _status = true;
        }
        public void CloseConnection()
        {
            if (!_status)
            {
                throw new InvalidOperationException("No open connection.");
            }

            CloseCore();
            _status = false;


        }

    }

}
