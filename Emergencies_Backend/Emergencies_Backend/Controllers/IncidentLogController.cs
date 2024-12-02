using Application.Views;
using Emergencies_Backend.Services;

namespace Application.Controllers
{
    public class IncidentLogController
    {
        private readonly IncidentLogService _incidentLogService;
        private readonly IncidentLogView _incidentLogView;

        public IncidentLogController(IncidentLogService incidentLogService, IncidentLogView incidentLogView)
        {
            _incidentLogService = incidentLogService;
            _incidentLogView = incidentLogView;
        }

        public void ViewIncidents()
        {
            // Логика контроллера
            Console.WriteLine("Incident Log Controller: Viewing incidents...");
            _incidentLogView.Render(); // Вызов Render на соответствующем View
        }
    }
}
