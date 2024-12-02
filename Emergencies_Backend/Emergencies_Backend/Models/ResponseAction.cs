using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencies_Backend.Models
{
    enum ResponseAction
    {
        Call_fire_department,
        Call_police,
        Call_medical_services,
        Notify_admin,
        Escalate_to_manager,
        Log_and_monitor
    }
}
