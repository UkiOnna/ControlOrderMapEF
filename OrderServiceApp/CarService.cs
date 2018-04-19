using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
   public class CarService
    {
        public void CarIsMoving(Car car,OrderContext context)
        {
            LocationHistory history = new LocationHistory();
            history.Locations.ToList().Add(car.Location);
            context.LocationHistory.Add(history);
            context.SaveChanges();
        }
    }
}
