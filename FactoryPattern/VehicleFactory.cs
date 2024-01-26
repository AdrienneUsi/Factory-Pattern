namespace FactoryPatternVehicle
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
               
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }

}