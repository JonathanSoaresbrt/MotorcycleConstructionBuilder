using MotorcycleConstruction.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Director
{
    public class Director
    {
        public Director(MotorcycleBuilder builder)
        {
            builder.AddComponentsMotorcycle();
            builder.BuildMotorCycle();
            builder.TestMotorCycle();
        }
    }
}
