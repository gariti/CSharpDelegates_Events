using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegates_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1"};
            VideoEncoder videoEncoder = new VideoEncoder(); //publisher
            MailService mailService = new MailService();  //subscriber
            MessageService messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

            Console.ReadKey();
        }
    }
}
