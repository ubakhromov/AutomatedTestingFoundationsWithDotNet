namespace AutomatedTestingFoundationsWithDotNet
{
    public class Plane : IFlyeble
    {
        private const double InitialSpeedKmPerHour = 200;
        private const double SpeedIncrementKmPerHour = 10;
        private const int SpeedIncrementDistanceKm = 10;
        private DistanceCalculator distanceCalculator;

        public Coordinate CurrentPosition { get; set; }

        public void FlyTo(Coordinate destination) //the aircraft increases speed by 10 km/h every 10 km of flight from an initial speed of 200 km/h
        {
            double distance = distanceCalculator.CalculateDistance(CurrentPosition, destination);
            TimeSpan flightTime = TimeSpan.Zero;

            double currentSpeed = InitialSpeedKmPerHour;
            double remainingDistance = distance;

            while (remainingDistance > 0)
            {
                double distanceCovered = Math.Min(remainingDistance, SpeedIncrementDistanceKm);
                remainingDistance -= distanceCovered;
                double time = distanceCovered / currentSpeed;
                flightTime += TimeSpan.FromHours(time);
                currentSpeed += SpeedIncrementKmPerHour;
            }

            Console.WriteLine($"Flying from ({CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}) to " +
                $"({destination.X}, {destination.Y}, {destination.Z})");

            Console.WriteLine($"Estimated flight time: {flightTime}");
            CurrentPosition = destination;
        }

        public TimeSpan GetFlightTime(Coordinate destination)
        {
            double distance = distanceCalculator.CalculateDistance(CurrentPosition, destination);
            double currentSpeed = InitialSpeedKmPerHour;
            double remainingDistance = distance;
            TimeSpan flightTime = TimeSpan.Zero;

            while (remainingDistance > 0)
            {
                double distanceCovered = Math.Min(remainingDistance, SpeedIncrementDistanceKm);
                remainingDistance -= distanceCovered;
                double time = distanceCovered / currentSpeed;
                flightTime += TimeSpan.FromHours(time);
                currentSpeed += SpeedIncrementKmPerHour;
            }

            return flightTime;
        }
    }
}
