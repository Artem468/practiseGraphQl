using practiseGraphQl.Models;
using Faker;

namespace practiseGraphQl.Data
{
    public static class DataSeeder
    {
        public static void SeedData(BlogDbContext db)
        {
            if (!db.Clients.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var client = new Client
                    {
                        Name = Name.FullName(),
                        Address = Address.StreetAddress(),
                        Phone = Phone.Number(),
                        Email = Internet.Email()
                    };
                    db.Clients.Add(client);
                }

                db.SaveChanges();
            }

            if (!db.Vehicles.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var vehicle = new Vehicle
                    {
                        Make = Lorem.Words(1).First(),
                        Model = Lorem.Words(1).First(),
                        Year = RandomNumber.Next(1980, 2024),
                        Capacity = RandomNumber.Next(100, 1000),
                        LicensePlate = Lorem.Words(1).First(),
                        FuelRate = RandomNumber.Next(10, 50),
                    };
                    db.Vehicles.Add(vehicle);
                }

                db.SaveChanges();
            }

            if (!db.Drivers.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var driver = new Driver
                    {
                        Name = Name.FullName(),
                        LicenseNumber = RandomNumber.Next(1000000, 9999999),
                        Phone = Phone.Number(),
                        DateOfHire = DateTime.Now
                    };
                    db.Drivers.Add(driver);
                }

                db.SaveChanges();
            }

            if (!db.Waybills.Any())
            {
                var clients = db.Clients.ToList();
                var vehicles = db.Vehicles.ToList();
                var drivers = db.Drivers.ToList();

                for (int i = 1; i <= 10; i++)
                {
                    var waybill = new Waybill
                    {
                        Date = DateTime.Now,
                        ClientId = clients[RandomNumber.Next(0, clients.Count - 1)].Id,
                        VehicleId = vehicles[RandomNumber.Next(0, vehicles.Count - 1)].Id,
                        DriverId = drivers[RandomNumber.Next(0, drivers.Count - 1)].Id,
                        RouteStart = Address.StreetAddress(),
                        RouteEnd = Address.StreetAddress(),
                        Distance = RandomNumber.Next(50, 500),
                    };
                    db.Waybills.Add(waybill);
                }

                db.SaveChanges();
            }
        }
    }
}