using AssessmentSolution.Model;
using Newtonsoft.Json;

namespace AssessmentSolution.OrderManagementModule
{
    public class OrderManagement : IOrderManagement
    {
        public Dictionary<string, Order> LoadOrders()
        {
            var orderList = new Dictionary<string, Order>();
            try
            {
                string orderJson = File.ReadAllText("Database\\coding-assigment-orders.json");
                orderList = JsonConvert.DeserializeObject<Dictionary<string, Order>>(orderJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured : {ex.Message}");
            }
            return orderList;
        }
        public void ScheduleOrders(Dictionary<string, Order> orderList, List<FlightSchedule> flightList)
        {
            try
            {
                foreach (var order in orderList)
                {

                    var orderDestinationFlight = flightList.Where(x => x.arrival == order.Value.destination && x.orders?.Count < 20).OrderBy(x => x.day).FirstOrDefault();
                    if (orderDestinationFlight != null && orderDestinationFlight.orders?.Count < 20)
                    {
                        orderDestinationFlight.orders.Add(new Order
                        {
                            orderId = order.Key,
                            destination = order.Value.destination
                        });

                        Console.WriteLine($"order: {order.Key}, flightNumber: {orderDestinationFlight.flightNumber}, departure: {orderDestinationFlight.departure}, arrival:  {orderDestinationFlight.arrival}, day:  {orderDestinationFlight.day}");
                    }
                    else
                    {
                        Console.WriteLine($"order: {order.Key}, flightNumber: not scheduled");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured : {ex.Message}");
            }
        }

    }
}
