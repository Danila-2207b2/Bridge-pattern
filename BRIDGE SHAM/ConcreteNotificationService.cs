using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class ConcreteNotificationService : NotificationService
    {
        public ConcreteNotificationService(INotification notification) : base(notification) { }
        public override void NotifyText(string text)
        {
            _notification.SendText(text);
        }
        public override void NotifyHtml(string html)
        {
            _notification.SendHtml(html);
        }

    }
}
