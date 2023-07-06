namespace AutomatedTestingFoundationsWithDotNet
{
    public class Drone : IFlyeble
    {
        private const double MaxDistanceKm = 1000;
        private const double HoverTimeMinutes = 1;
        private const double HoverIntervalMinutes = 10;
        private DistanceCalculator distanceCalculator;
        public Coordinate CurrentPosition { get; set; }

        public void FlyTo(Coordinate destination) //the drone hovers in the air every 10 minutes of flight for 1 minute.
        {
            if (distanceCalculator.CalculateDistance(CurrentPosition, destination) > MaxDistanceKm)
            {
                Console.WriteLine("Cannot fly to the destination. Maximum distance exceeded.");
                return;
            }

            double distance = distanceCalculator.CalculateDistance(CurrentPosition, destination);
            TimeSpan flightTime = TimeSpan.FromMinutes(0);

            while (distance > 0)
            {
                double hoverTime = Math.Min(distance, HoverIntervalMinutes);
                distance -= hoverTime;
                flightTime += TimeSpan.FromMinutes(hoverTime + HoverTimeMinutes);
            }

            Console.WriteLine($"Flying from ({CurrentPosition.X}, {CurrentPosition.Y}, {CurrentPosition.Z}) " +
                $"to ({destination.X}, {destination.Y}, {destination.Z})");

            Console.WriteLine($"Estimated flight time: {flightTime}");
            CurrentPosition = destination;
        }
        public TimeSpan GetFlightTime(Coordinate destination)
        {
            if (distanceCalculator.CalculateDistance(CurrentPosition, destination) > MaxDistanceKm)
            {
                Console.WriteLine("Cannot calculate flight time. Maximum distance exceeded.");
                return TimeSpan.Zero;
            }

            double distance = distanceCalculator.CalculateDistance(CurrentPosition, destination);
            TimeSpan flightTime = TimeSpan.FromMinutes(0);

            while (distance > 0)
            {
                double hoverTime = Math.Min(distance, HoverIntervalMinutes);
                distance -= hoverTime;
                flightTime += TimeSpan.FromMinutes(hoverTime + HoverTimeMinutes);
            }

            return flightTime;
        }
    }
}
