using MotorcycleConstruction.Domain;
using MotorcycleConstruction.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleConstruction.Builders
{
    public class EletricMotorcyleBuilder : MotorcycleBuilder
    {
        public override void AddComponentsMotorcycle()
        {
            _componentsMotorcyle = new List<ComponentsMotorcyle>();

            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.Handlebar));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.Structure));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.EngineEletric));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.Suspension));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.RearView));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.Tires));
            _componentsMotorcyle.Add(new ComponentsMotorcyle(EMotorcycleComponents.BatteriesEngine));
        }

        public override void BuildMotorCycle()
        {
            _eletricMotorcycle = new EletricMotorcycle(1, "Ducati Monster", "Red", "200-HP", "50kg", "300km/h", "12v", "100MM", "100MM", "100MM", "17pol", "1pol", "180kg", DateTime.Now, _componentsMotorcyle);

            Console.WriteLine($"BuildMotorCycle Eletric id : {_eletricMotorcycle.Id} Marca : {_eletricMotorcycle.Model}");
        }

        public override void TestMotorCycle()
        {
            if (_eletricMotorcycle is not null)
                Console.WriteLine("Test carried out, motorcycle released for sale");
            else
                Console.WriteLine("Error Constructor Motorcycle");
        }
    }
}
