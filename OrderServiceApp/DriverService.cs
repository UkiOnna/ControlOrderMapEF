using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
    public class DriverService
    {
        public void AddDriver(int id, string name, int age, OrderContext context)
        {
            Driver tempDriver = new Driver { Age = 17, Id = 1, Name = "Lucifer" };
            context.Drivers.Add(tempDriver);
            context.SaveChanges();
        }
    }
}
