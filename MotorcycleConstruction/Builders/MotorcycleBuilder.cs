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
        protected Motorcycle _motorcycle;
        public Motorcycle Motorcycle => _motorcycle;
        protected ComponentsMotorcyle _componentsMotorcyle;
        public ComponentsMotorcyle ComponentsMotorcyle => _componentsMotorcyle;
        public abstract void AddComponentsMotorcycle();
        public abstract void BuildMotorCycle();
        public abstract void TestMotorCycle();

    }
}
