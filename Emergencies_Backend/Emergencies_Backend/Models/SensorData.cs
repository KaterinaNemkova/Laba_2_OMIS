using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Models
{
    public class SensorData
    {
        private readonly int Id;
        private readonly SensorType Type;
        private readonly double Value;
        private readonly DateTime TimeStump;
    }
}
