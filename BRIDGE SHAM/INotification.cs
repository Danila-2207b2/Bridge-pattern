using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public interface INotification
    {
        void SendText(string text);
        void SendHtml(string html);
    }
}
