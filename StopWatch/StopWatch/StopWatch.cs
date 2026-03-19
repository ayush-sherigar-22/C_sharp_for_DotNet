namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public void StartWatch()
        {
            if (_isRunning)
                throw new InvalidOperationException("Watch is already running");

            _isRunning = true;
            _startTime = DateTime.Now;
        }

        public void EndWatch()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Watch is not running");

            _isRunning = false;
            _endTime = DateTime.Now;
        }

        public TimeSpan CalculateTime()
        {
            return _endTime - _startTime;
        }
    }
}