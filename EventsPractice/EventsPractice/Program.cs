using System;
using System.Reflection;

namespace EventsPractice
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var video = new Video() { Title = "Video 1" };

            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); //subscriber
            var TextMessageService = new TextMessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += TextMessageService.OnVideoEncoded;
            videoEncoder.Encode(video);

            
        }


    }
    
}
