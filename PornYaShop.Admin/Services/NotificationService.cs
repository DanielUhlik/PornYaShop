using PornYaShop.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Admin.Services
{
    public class NotificationService
    {

        public event Action<Notification> OnNotificationShow;

        public void ShowNotification(string text, NotificationStatus status)
        {
            var notification = new Notification(text, status);
            OnNotificationShow?.Invoke(notification);
        }

    }
}
