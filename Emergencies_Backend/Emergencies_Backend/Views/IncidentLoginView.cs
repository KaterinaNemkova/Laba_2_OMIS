using Application.Controllers;
using Emergencies_Backend.Services;

namespace Application.Views
{
    public class IncidentLogView : AbstractView
    {
        private readonly IncidentLogController _controller;

        public IncidentLogView(IncidentLogController controller)
        {
            _controller = controller;
        }

        public override void Render()
        {
            // Реализация метода Render для IncidentLogView
            // Например, вывод информации о происшествиях
            Console.WriteLine("Rendering Incident Log View...");
            _controller.ViewIncidents(); // Взаимодействие с сервисом для получения данных
        }
    }
}
