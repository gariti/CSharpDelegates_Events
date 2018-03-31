using System;
using System.Threading;

namespace CSharp_Delegates_Events
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding " + video.Title + "....");
            Thread.Sleep(3000);
        }
    }
}