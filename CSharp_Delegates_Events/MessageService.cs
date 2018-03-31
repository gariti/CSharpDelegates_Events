using System;

namespace CSharp_Delegates_Events
{
    public class MessageService
    {
            public void OnVideoEncoded(object source, VideoEventArgs e)
            {
                Console.WriteLine("MessageService: Sending an SMS message..." + e.Video.Title);
            }
    }
}