using MotorcycleConstruction.Domain.Enum;
using MotorcycleConstruction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Builders
{
    public class CombustionMotorcyleBuilder : MotorcycleBuilder
    {
        public override void AddComponentsMotorcycle()
        {
            _componentsMotorcyle = new ComponentsMotorcyle();

            _componentsMotorcyle.MotorcycleCombustionComponents = EMotorcycleCombustionComponents.Handlebar |
                EMotorcycleCombustionComponents.Engine | EMotorcycleCombustionComponents.Handlebar | EMotorcycleCombustionComponents.Wheels |
                EMotorcycleCombustionComponents.Structure | EMotorcycleCombustionComponents.Suspension | EMotorcycleCombustionComponents.FuelTank;
        }

        public override void BuildMotorCycle()
        {
            _motorcycle = new Motorcycle(2, "Ducati Monster", "Red", "200-HP", "50kg", "300km/h", "12v", "100MM", "100MM", "100MM", "17pol", "1pol", "180kg", "17pol", "100MM", DateTime.Now, _componentsMotorcyle);

            Console.WriteLine($"BuildMotorCycle Combustion id : {_motorcycle.Id} Marca : {_motorcycle.Model} Components : {_componentsMotorcyle.MotorcycleCombustionComponents}");
        }

        public override void TestMotorCycle()
        {
            if (_motorcycle is not null)
                Console.WriteLine("Test carried out, motorcycle released for sale");
            else
                Console.WriteLine("Error Constructor Motorcycle");
        }
    }
}
