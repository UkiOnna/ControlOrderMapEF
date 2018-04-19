using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(OrderContext context=new OrderContext())
            {
                Location companyOrderLocation = new Location { Address = "OrCo/14", Id = 1, X = 1, Y = 1 };
                Location companyProviderLoca = new Location { Address = "ProCo/11", Id = 2, X = 20, Y = 20 };
                Location carLocation = new Location { Address = "ProCo/11", Id = 3, X = 19, Y = 19};

                Company orderCompany = new Company { Id = 1, Location = companyOrderLocation, LocationId = 1 };
                Company providerCompany = new Company { Id = 2, Location = companyProviderLoca, LocationId = 2 };

                //DriverService driverServ = new DriverService();
                // driverServ.AddDriver(1, "Lucifer", 17,context);

                Driver driver = new Driver { Age = 17, Id = 1, Name = "Lucifer" };

                CarType type = new CarType { Id = 1, Type = "truck" };

                Car car = new Car { Color = "Yellow", DriverId = 1, Id = 1,Driver=driver,Location=carLocation,LocationId=3,Type=type,TypeId=1 };

                Cargo cargo = new Cargo { Count = 10, Id = 1, Name = "Fridge" };


                //можно добавить еще куча сервисов...



            }
        }
    }
}
