using MotorcycleConstruction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Builders
{
    public abstract class MotorcycleBuilder
    {
        protected CombustionMotorcycle _motorcycle;
        public CombustionMotorcycle Motorcycle => _motorcycle;
        protected EletricMotorcycle _eletricMotorcycle;
        public EletricMotorcycle EletricMotorcycle => _eletricMotorcycle;
        protected List<ComponentsMotorcyle> _componentsMotorcyle;
        public List<ComponentsMotorcyle> ComponentsMotorcyle => _componentsMotorcyle;
        public abstract void BuildMotorCycle();
        public abstract void AddComponentsMotorcycle();
        public abstract void TestMotorCycle();

    }
}
