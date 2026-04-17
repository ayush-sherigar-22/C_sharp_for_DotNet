using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SyncAsyncDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Method 1
            //DownloadHtml("http://msdn.microsoft.com");

            // Method 2
            // DownloadHtmlAsync("http://msdn.microsoft.com");


            // Method 3
            //var html = GetHtml("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0, 200));


            // Method 4
            //var html = await GetHtmlAsync("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0, 200));


            // Other way of doing method 4
            var gethtml = GetHtmlAsync("http://msdn.microsoft.com");  // Start the task
            MessageBox.Show("Process is going on"); // till then do other task
            var html = await gethtml;              // tell the compiler to get the result of task here
            MessageBox.Show(html.Substring(0, 200));  // display the task

        }

       // Normal Method 
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\user\ayush\source\repos"))
            {
                streamWriter.Write(html);
            }
        }

        // Using Async
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\user\ayush\source\repos"))
            {
                await streamWriter.WriteAsync(html);
            }

        }

        // Normal Method returning string
        public string  GetHtml(string url)
        {
            var webclient = new WebClient();

            return webclient.DownloadString(url);
        }

        // Async Task method returning string

        public async Task<string> GetHtmlAsync(string url)
        {

            var webclient = new WebClient();

            return await webclient.DownloadStringTaskAsync(url);

        }
    }
}