using Emergencies_Backend.Models;
using Emergencies_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Services
{
    public interface NotificationService
    {
        void NotifyUser(Alert alert);
    }
}
