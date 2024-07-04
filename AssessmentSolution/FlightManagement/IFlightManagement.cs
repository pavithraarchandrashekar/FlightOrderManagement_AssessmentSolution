using AssessmentSolution.Model;

namespace AssessmentSolution.FlightManagementModule
{
    interface IFlightManagement
    {
        public List<FlightSchedule> GetFlightSchedule();
    }
}
