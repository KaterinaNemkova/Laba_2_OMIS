using Application.Controllers;
using Emergencies_Backend.Models;
using Emergencies_Backend.Services;

namespace Application.Views
{
    public class ConfigurationView : AbstractView
    {
        private readonly ConfigurationController _configurationController;

        public ConfigurationView(ConfigurationController controller)
        {
           _configurationController = controller;
        }

        public override void Render()
        {
            // Реализация метода Render для ConfigurationView
            // Например, вывод конфигурации системы
            Console.WriteLine("Rendering Configuration View...");
            _configurationController.Configure(); // Взаимодействие с сервисом для настройки системы
        }
    }
}
