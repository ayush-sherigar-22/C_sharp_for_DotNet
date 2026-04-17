using System;
using System.Threading.Tasks;

namespace SyncAsync
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var user = new UserDashboard("Ayush", "Cake123");

            var tasks = new Task<string>[]
            {
                user.GetProfile(),
                user.GetOrders(),
                user.GetNotification()
            };

            foreach (var task in tasks)
            {
                try
                {
                    var result = await task;
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("\nDashboard Loaded (Partial/Full)");
        }
    }

    public class UserDashboard
    {
        private readonly string _userName;
        private readonly string _orderId;

        public UserDashboard(string username, string orderid)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(orderid))
            {
                throw new ArgumentNullException("Invalid Credentials");
            }
            _userName = username;
            _orderId = orderid;
        }

        public async Task<string> GetProfile()
        {
            await Task.Delay(2000);
            return $"Profile loaded for {_userName}";
        }

        public async Task<string> GetOrders()
        {
            await Task.Delay(4000);

            // Simulate failure
            //throw new Exception("Orders service failed!");

            return $"Orders loaded for {_userName} with OrderID : {_orderId}";
        }

        public async Task<string> GetNotification()
        {
            await Task.Delay(1000);
            return $"Notification ready for {_userName} with OrderID {_orderId}";
        }
    }
}