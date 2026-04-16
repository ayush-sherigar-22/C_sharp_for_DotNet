using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args) 
        {

          Notification notify = SMS;
            notify += EMail;
            notify += WhatsApp;
            notify += Push;

            notify();
        }

        public delegate void Notification();
        public static void SMS()
        {
            Console.WriteLine("Sending an SMS notification");
        }

        public static void EMail()
        {
            Console.WriteLine("Sending an E-Mail notification");
        }
        public static void WhatsApp()
        {
            Console.WriteLine("Sending WhatsApp");
        }

        public static void Push()
        {
            Console.WriteLine("Sending an Push notification");
        }
        
    }



}
