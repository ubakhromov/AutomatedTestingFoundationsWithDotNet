namespace AutomatedTestingFoundationsWithDotNet
{
    public class DistanceCalculator
    {
        public double CalculateDistance(Coordinate source, Coordinate destination) //method calculate a distance
        {
            double dx = destination.X - source.X;
            double dy = destination.Y - source.Y;
            double dz = destination.Z - source.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public TimeSpan CalculateFlightTime(double distance, double speed) //method calculate a flight time
        {
            double hours = distance / speed;
            TimeSpan flightTime = TimeSpan.FromHours(hours);
            return flightTime;
        }
    }
}
