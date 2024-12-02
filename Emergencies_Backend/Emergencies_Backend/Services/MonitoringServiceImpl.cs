using Emergencies_Backend.Models;
using Emergencies_Backend.Repositories;
using Emergencies_Backend.Services;
using System.Security.Cryptography.X509Certificates;

namespace Application.Services
{
    public class MonitoringServiceImpl : MonitoringService
    {
        private readonly MonitoringRepository _monitoringRepository;

        public MonitoringServiceImpl(MonitoringRepository monitoringRepository)
        {
            _monitoringRepository = monitoringRepository;
        }

        public List<SensorData> MonitorRealTimeData()
        {
            _monitoringRepository.FindAll();
            return [];
        }
    }
}
