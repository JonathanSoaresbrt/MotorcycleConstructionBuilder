using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Domain.Enum
{
    [Flags]
    public enum EMotorcycleEletricComponents
    {
        EngineEletric = 1,
        BatteriesEngine = 2,
        Handlebar = 3,
        Wheels = 4,
        Tires = 5,
        Structure = 6,
        Suspension = 7,
        RearView = 8,
        FuelTank = 9
    }
}
