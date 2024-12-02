using Application.Views;
using Emergencies_Backend.Services;

namespace Application.Controllers
{
    public class ConfigurationController
    {
        private readonly ConfigurationService _configurationService;
        private readonly ConfigurationView _configurationView;

        public ConfigurationController(ConfigurationService configurationService, ConfigurationView configurationView)
        {
            _configurationService = configurationService;
            _configurationView = configurationView;
        }

        public void Configure()
        {
            // Логика контроллера
            Console.WriteLine("Configuration Controller: Configuring system...");
            _configurationView.Render(); // Вызов Render на соответствующем View
        }
    }
}
