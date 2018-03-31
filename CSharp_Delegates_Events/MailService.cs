using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegates_Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
