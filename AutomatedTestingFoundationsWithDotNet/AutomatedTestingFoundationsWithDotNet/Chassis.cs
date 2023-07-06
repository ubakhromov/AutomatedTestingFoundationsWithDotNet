namespace AutomatedTestingFoundationsWithDotNet
{
    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public string Number { get; set; }
        public int PermissibleLoad { get; set; }

        public Chassis(int wheelsNumber, string number, int permissibleLoad)
        {
            WheelsNumber = wheelsNumber;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }
    }
}
