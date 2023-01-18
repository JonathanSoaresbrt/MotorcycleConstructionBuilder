using MotorcycleConstruction.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Domain
{
    public class ComponentsMotorcyle
    {
        public EMotorcycleComponents MotorcycleComponents { get; private set; }
        public ComponentsMotorcyle(EMotorcycleComponents motorcycleComponents)
        {
            MotorcycleComponents = motorcycleComponents;
        }
    }
}
