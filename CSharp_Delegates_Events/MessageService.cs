using System;

namespace CSharp_Delegates_Events
{
    public class MessageService
    {
            public void OnVideoEncoded(object source, EventArgs e)
            {
                Console.WriteLine("MessageService: Sending an SMS message...");
            }
    }
}