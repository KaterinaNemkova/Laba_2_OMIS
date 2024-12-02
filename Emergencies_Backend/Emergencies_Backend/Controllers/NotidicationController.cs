using Application.Views;
using Emergencies_Backend.Services;

namespace Application.Controllers
{
    public class NotificationController
    {
        private readonly NotificationService _notificationService;
        private readonly NotificationView _notificationView;

        public NotificationController(NotificationService notificationService, NotificationView notificationView)
        {
            _notificationService = notificationService;
            _notificationView = notificationView;
        }

        public void NotifyUser()
        {
            // Логика контроллера
            Console.WriteLine("Notification Controller: Notifying user...");
            _notificationView.Render(); // Вызов Render на соответствующем View
        }
    }
}
