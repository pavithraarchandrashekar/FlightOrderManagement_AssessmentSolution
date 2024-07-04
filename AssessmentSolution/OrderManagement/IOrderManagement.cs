using AssessmentSolution.Model;

namespace AssessmentSolution.OrderManagementModule
{
    interface IOrderManagement
    {
        public Dictionary<string, Order> LoadOrders();
        public void ScheduleOrders(Dictionary<string, Order> orderList, List<FlightSchedule> flightList);
    }
}
