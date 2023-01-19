using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Domain.Enum
{
    [Flags]
    public enum EMotorcycleCombustionComponents
    {
        Engine = 1,
        Handlebar = 2,
        Wheels = 3,
        Tires = 4,
        Structure = 5,
        Suspension = 6,
        RearView = 7,
        FuelTank = 8
    }
}
