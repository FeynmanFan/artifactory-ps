namespace Globomantics.Satellite
{
    public enum StatusCode
    {
        Unknown = 0,
        Healthy = 1,
        Error = 2
    }
    public class Satellite
    {
        public string Name { get; set; }

        public double Altitude { get; set; }

        public double Azimuth { get; set; }

        public StatusCode HealthCheck()
        {
            return StatusCode.Healthy;
        }
    }
}