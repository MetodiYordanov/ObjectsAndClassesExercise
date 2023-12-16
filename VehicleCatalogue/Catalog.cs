namespace VehicleCatalogue
{
    public class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
