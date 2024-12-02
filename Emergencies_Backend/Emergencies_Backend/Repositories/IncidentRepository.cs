using Emergencies_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Repositories
{
    public interface IncidentRepository
    {
        void FindAll();
        void Save(Incident incident);
    }
}
