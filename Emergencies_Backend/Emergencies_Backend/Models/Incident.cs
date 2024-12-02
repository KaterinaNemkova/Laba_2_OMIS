using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Models
{
    public class Incident
    {
        private readonly int Id;
        private readonly ThreatType Type;
        private readonly ThreatSeverity Severity;
        private readonly string Description=string.Empty;
        private readonly IncidentStatus Status;
        private readonly ResponseAction ResponseTaken;
        private readonly DateTime TimeStump;
    }
}
