using Emergencies_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Services
{
    public interface IncidentLogService
    {
        void LoginIncident(Incident incident);
    }
}
