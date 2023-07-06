namespace AutomatedTestingFoundationsWithDotNet
{
    public class Bird : IFlyeble
    {
        private const double MaxSpeedKmPerHour = 20;
        private DistanceCalculator distanceCalculator;

        public Coordinate CurrentPosition { get; set; }

        public void FlyTo(Coordinate destination) 
        {
            //the bird flies the entire distance at a constant speed in the range of 0-20 km/h

            double distance = distanceCalculator.
                CalculateDistance(CurrentPosition, destination);

            TimeSpan flightTime = distanceCalculator.
                CalculateFlightTime(distance, MaxSpeedKmPerHour);

            Console.WriteLine($"Flying from ({CurrentPosition.X}," +
                $" {CurrentPosition.Y}, {CurrentPosition.Z}) to " +
                $"({destination.X}, {destination.Y}, {destination.Z})");

            Console.WriteLine($"Estimated flight time: {flightTime}");
            CurrentPosition = destination;
        }

        public TimeSpan GetFlightTime(Coordinate destination)
        {
            double distance = distanceCalculator.
                CalculateDistance(CurrentPosition, destination);

            TimeSpan flightTime = distanceCalculator.
                CalculateFlightTime(distance, MaxSpeedKmPerHour);

            return flightTime;
        }
    }
}
