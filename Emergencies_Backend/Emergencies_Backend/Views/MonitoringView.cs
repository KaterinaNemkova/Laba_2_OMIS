using Application.Controllers;
using Emergencies_Backend.Services;

namespace Application.Views
{
    public class MonitoringView : AbstractView
    {
        private readonly MonitoringController _controller;

        public MonitoringView(MonitoringController controller)
        {
            _controller = controller;
        }

        public override void Render()
        {
            // Реализация метода Render для MonitoringView
            // Например, вывод информации о мониторинге
            Console.WriteLine("Rendering Monitoring View...");
            _controller.Monitor(); // Взаимодействие с сервисом для получения данных
        }
    }
}
