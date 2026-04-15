using System;
using System.Linq.Expressions;

namespace EventPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var securityNotification = new SecurityNotificationService();
            var alarmSystem = new AlarmSystem();

            var security = new SecuritySystem();

            security.DoorOpened += alarmSystem.OnDoorOpened;
            security.DoorOpened += securityNotification.OnDoorOpened;

            security.MotionDetected += alarmSystem.OnMotionDetected;
            security.MotionDetected += securityNotification.OnMotionDetected;

            Console.WriteLine("-----------------------------");
            security.DoorSecurityCheck("Front Door", true);
            Console.WriteLine("-----------------------------");
            security.MotionSecurityCheck(true, "Living Room", DateTime.Now);


        }

    }
}