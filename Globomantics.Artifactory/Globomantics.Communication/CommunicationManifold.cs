namespace Globomantics.Communication
{
    using Globomantics.Satellite;

    public static class CommunicationManifold
    {
        public static List<Satellite> GetAll(double altitude = 0)
        {
            return new List<Satellite>
            {
                new Satellite
                {
                    Name = "Telsat 1",
                    Altitude = 36000.0d,
                    Azimuth = 27.3
                },
                new Satellite
                {
                    Name = "Telsat 2",
                    Altitude = 36000.0d,
                    Azimuth = 87.5
                },
            }.Where(x => x.Altitude > altitude).ToList();
        }
    }
}