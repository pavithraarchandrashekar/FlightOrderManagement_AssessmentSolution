using AssessmentSolution.Model;

namespace AssessmentSolution.FlightManagementModule
{
    public class FlightManagement : IFlightManagement
    {
        public List<FlightSchedule> GetFlightSchedule()
        {
            var flightList = new List<FlightSchedule>();
            try
            {
                string text = File.ReadAllText("Database\\flightSchedule.json");
                flightList = System.Text.Json.JsonSerializer.Deserialize<List<FlightSchedule>>(text);
                if (flightList.Any())
                {
                    foreach (var flight in flightList)
                    {
                        Console.WriteLine($"Flight : {flight.flightNumber}, departure : {flight.departure}, arrival : {flight.arrival}, day : {flight.day}");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception occured : {ex.Message}");
            }
            return flightList;

        }
    }
}
