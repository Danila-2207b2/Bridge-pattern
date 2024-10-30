using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public abstract class NotificationService
    {
        protected INotification _notification;
        public NotificationService(INotification notification)
        {
            _notification = notification;
        }
        public abstract void NotifyText(string text);
        public abstract void NotifyHtml(string html);
    }
}
