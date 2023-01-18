
using MotorcycleConstruction.Builders;
using MotorcycleConstruction.Director;
using MotorcycleConstruction.Domain;

CombustionMotorcyleBuilder builderCombustionMotorcyle;
EletricMotorcyleBuilder builderEletricMotorcyle;

Director director;

builderCombustionMotorcyle = new CombustionMotorcyleBuilder();
builderEletricMotorcyle = new EletricMotorcyleBuilder();

director = new Director(builderCombustionMotorcyle);
director = new Director(builderEletricMotorcyle);
