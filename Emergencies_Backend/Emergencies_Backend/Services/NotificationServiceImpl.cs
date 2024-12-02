using Emergencies_Backend.Models;
using Emergencies_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Services
{
    public class NotificationServiceImpl:NotificationService
    {
        private readonly AlertRepository _alertRepository;

        public NotificationServiceImpl(AlertRepository repository)
        {
            _alertRepository = repository;
        }

        public void NotifyUser(Alert alert)
        {
            _alertRepository.Save(alert);
        }
    }
}
