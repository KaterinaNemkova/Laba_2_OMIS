using Application.Views;
using Emergencies_Backend.Services;

namespace Application.Controllers
{
    public class MonitoringController
    {
        private readonly MonitoringService _monitoringService;
        private readonly MonitoringView _monitoringView;

        public MonitoringController(MonitoringService monitoringService, MonitoringView monitoringView)
        {
            _monitoringService = monitoringService;
            _monitoringView = monitoringView;
        }

        public void Monitor()
        {
            // Логика контроллера
            Console.WriteLine("Monitoring Controller: Monitoring data...");
            _monitoringView.Render(); // Вызов Render на соответствующем View
        }
    }
}
