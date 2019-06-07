using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Admin.Data
{
    public enum NotificationStatus
    {
        Primary, Success, Warning, Error
    }

    public class Notification
    {
        public Notification(string text, NotificationStatus status)
        {
            Text = text;
            NotificationStatus = status;
        }

        public string Text { get; set; }
        public NotificationStatus NotificationStatus { get; set; }
    }
}
