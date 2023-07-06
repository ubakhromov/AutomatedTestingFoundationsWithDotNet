namespace AutomatedTestingFoundationsWithDotNet
{
    public interface IFlyeble
    {
        void FlyTo(Coordinate destination);
        TimeSpan GetFlightTime(Coordinate destination);
    }
}
