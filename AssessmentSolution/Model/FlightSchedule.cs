namespace AssessmentSolution.Model
{
    public class FlightSchedule
    {
        public int flightNumber { get; set; }
        public string? departure { get; set; }
        public string? arrival { get; set; }
        public int day { get; set; }
        public List<Order> orders { get; set; } = new List<Order>();

    }
}
