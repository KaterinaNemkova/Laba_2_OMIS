using Application.Controllers;
using Emergencies_Backend.Services;

namespace Application.Views
{
    public class NotificationView : AbstractView
    {
        private readonly NotificationController _notificationController;

        public NotificationView(NotificationController controller)
        {
            _notificationController = controller;
        }

        public override void Render()
        {
            // Реализация метода Render для NotificationView
            // Например, вывод уведомлений
            Console.WriteLine("Rendering Notification View...");
            _notificationController.NotifyUser(); // Взаимодействие с сервисом для отправки уведомлений
        }
    }
}
