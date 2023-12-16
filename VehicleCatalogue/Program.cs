using System.Text;
using VehicleCatalogue;

Catalog catalog = new Catalog();

string input = Console.ReadLine();

while (input != "end")
{
    string[] vehicleComponents = input.Split('/');
    string vehicleType = vehicleComponents[0];
    string vehicleBrand = vehicleComponents[1];
    string vehicleModel = vehicleComponents[2];
    int horsePowerOrWeght = int.Parse(vehicleComponents[3]);

    if (vehicleType == "Car")
    {
        Car currentCar = new Car
        {
            Brand = vehicleBrand,
            Model = vehicleModel,
            HorsePower = horsePowerOrWeght,
        };

        catalog.Cars.Add(currentCar);
    }
    else if (vehicleType == "Truck")
    {
        Truck currentTruck = new Truck
        {
            Brand = vehicleBrand,
            Model = vehicleModel,
            Weight = horsePowerOrWeght,
        };

        catalog.Trucks.Add(currentTruck);
    }

    input = Console.ReadLine();
}

StringBuilder sb = new StringBuilder();

if (catalog.Cars.Count > 0)
{
    sb.AppendLine("Cars:");

    foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
    {
        sb.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0)
{
    sb.AppendLine("Trucks:");

    foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
    {
        sb.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

Console.WriteLine(sb.ToString().Trim());