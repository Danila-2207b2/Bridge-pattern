using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class EmailNotification : INotification
    {
        public void SendText(string text)
        {
            Console.WriteLine($"Отправка текстового сообщеия по Email: {text}");
        }

        public void SendHtml(string html)
        {
            Console.WriteLine($"Отправка сообщения формата HTML по Email: <html><head><title>{html}</title></head></html>");
        }
    }
}

