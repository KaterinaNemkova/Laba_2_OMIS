using Emergencies_Backend.Models;
using Emergencies_Backend.Repositories;
using Emergencies_Backend.Services;

namespace Application.Services
{
    public class ConfigurationServiceImpl : ConfigurationService
    {
        private readonly ConfigurationRepository _configurationRepository;

        public ConfigurationServiceImpl(ConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        public void ConfigureSystem(Configuration configuration)
        {
            return;
        }
    }
}
