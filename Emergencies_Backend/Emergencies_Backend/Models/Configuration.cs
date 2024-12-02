using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Models
{
    public class Configuration
    {
        private readonly int Id;
        private readonly Dictionary<ThreatType, ResponseAction> ResponseSettings;
        private readonly List<ThreatType> EnabledThreats;
    }
}
