using System;
using System.Collections.Generic;
using System.Linq;
using AssessmentSolution.FlightManagementModule;
using AssessmentSolution.OrderManagementModule;

namespace AssessmentSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User story #1 - Loading the flight schedule
            Console.WriteLine("********** FLight Schedule *********");
            Console.WriteLine("*");
            Console.WriteLine("*");
            FlightManagement flightMgmt = new FlightManagement();
            var flightList = flightMgmt.GetFlightSchedule();
            Console.WriteLine("************************************");
          

            //User story #2 - Loading the orders from JSON file and scheduling the same
            OrderManagement orderManagement = new OrderManagement();
            Console.WriteLine("********** Scheduled Orders *********");
            Console.WriteLine("*");
            Console.WriteLine("*");
            var orderList = orderManagement.LoadOrders();
            orderManagement.ScheduleOrders(orderList, flightList);
            Console.WriteLine("************************************");
   


        }
    }
}
