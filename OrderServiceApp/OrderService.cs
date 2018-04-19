using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
  public  class OrderService
    {
        public void CreateOrder(int id,Company customer,Company provider,Car car,Cargo cargo,DateTime OrderDate,OrderContext context)
        {
            Order tempOrder = new Order { Car = car, Cargo = cargo, CargoId = cargo.Id, CarId = car.Id, ComingDate = DateTime.Now, CustomerCompany = customer, CustomerId = customer.Id, Id = id, ProviderCompany = provider, ProviderId = provider.Id };
            context.Orders.Add(tempOrder);
            context.SaveChanges();
        }
    }
}
