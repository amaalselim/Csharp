using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch(AccidentException ex)
            {
                Console.WriteLine($"There was an accident at {ex.Location} preventing us from delivering your parcel:{ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Deliver Fails Due To : {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            finally
            {
                Console.WriteLine("END");
            }
            
        }
        private void Process(Delivery delivery)
        {
            FakeIt("Processing");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Unable To Process The Item");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel Is Damaged During The Process");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("345 some street", "ACCIDENT !!!!!");
            }
            
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAddressException($"'{delivery.Address} Is Invalid !!!'");
            }
            delivery.DeliveryStatus = DeliveryStatus.DELIVERD;
        }
        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");

        }

    }
    
}
