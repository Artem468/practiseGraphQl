using practiseGraphQl.Models;
using Microsoft.EntityFrameworkCore;

namespace practiseGraphQl.Data
{
    public class Mutation
    {
        [Serial]
        public async Task<Client?> UpdateClient([Service] BlogDbContext context, Client model)
        {
            var client = await context.Clients.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (client != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                    client.Name = model.Name;
                if (!string.IsNullOrEmpty(model.Address))
                    client.Address = model.Address;
                if (!string.IsNullOrEmpty(model.Email))
                    client.Email = model.Email;
                if (!string.IsNullOrEmpty(model.Phone))
                    client.Phone = model.Phone;

                context.Clients.Update(client);
                await context.SaveChangesAsync();
            }

            return client;
        }

        [Serial]
        public async Task DeleteClient(
            [Service] BlogDbContext context, Client model)
        {
            var client = await context.Clients.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (client != null)
            {
                context.Clients.Remove(client);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Client?> InsertClient(
            [Service] BlogDbContext context,
            string name,
            string address,
            string email,
            string phone)
        {
            var client = new Client
            {
                Name = name,
                Address = address,
                Phone = phone,
                Email = email
            };
            context.Clients.Add(client);
            await context.SaveChangesAsync();
            return client;
        }

        [Serial]
        public async Task<Driver?> UpdateDriver([Service] BlogDbContext context, Driver model)
        {
            var driver = await context.Drivers.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (driver != null)
            {
                if (!string.IsNullOrEmpty(model.Name))
                    driver.Name = model.Name;
                if (!string.IsNullOrEmpty(model.Phone))
                    driver.Phone = model.Phone;
                driver.DateOfHire = model.DateOfHire;
                driver.LicenseNumber = model.LicenseNumber;
                context.Drivers.Update(driver);
                await context.SaveChangesAsync();
            }

            return driver;
        }

        [Serial]
        public async Task DeleteDriver(
            [Service] BlogDbContext context, Driver model)
        {
            var driver = await context.Drivers.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (driver != null)
            {
                context.Drivers.Remove(driver);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Driver?> InsertDriver(
            [Service] BlogDbContext context,
            string name,
            int licenseNumber,
            string phone,
            DateTime dateOfHire
            )
        {
            var driver = new Driver
            {
                Name = name,
                LicenseNumber = licenseNumber,
                Phone = phone,
                DateOfHire = dateOfHire
            };
            context.Drivers.Add(driver);
            await context.SaveChangesAsync();
            return driver;
        }


        [Serial]
        public async Task<Vehicle?> UpdateVehicle([Service] BlogDbContext context, Vehicle model)
        {
            var vehicle = await context.Vehicles.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (vehicle != null)
            {
                if (!string.IsNullOrEmpty(model.Make))
                    vehicle.Make = model.Make;
                if (!string.IsNullOrEmpty(model.Model))
                    vehicle.Model = model.Model;
                if (!string.IsNullOrEmpty(model.LicensePlate))
                    vehicle.LicensePlate = model.LicensePlate;
                vehicle.Year = model.Year;
                vehicle.Capacity = model.Capacity;
                vehicle.FuelRate = model.FuelRate;
                context.Vehicles.Update(vehicle);
                await context.SaveChangesAsync();
            }

            return vehicle;
        }

        [Serial]
        public async Task DeleteVehicle(
            [Service] BlogDbContext context, Vehicle model)
        {
            var vehicle = await context.Vehicles.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (vehicle != null)
            {
                context.Vehicles.Remove(vehicle);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Vehicle?> InsertVehicle(
            [Service] BlogDbContext context, 
            string make,
            string model,
            int year,
            int capacity,
            string licensePlate,
            int fuelRate
            )
        {
            var vehicle = new Vehicle
            {
                Make = make,
                Model = model,
                Year = year,
                Capacity = capacity,
                LicensePlate = licensePlate,
                FuelRate = fuelRate
            };
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
            return vehicle;
        }


        [Serial]
        public async Task<Waybill?> UpdateWaybill([Service] BlogDbContext context, Waybill model)
        {
            var waybill = await context.Waybills.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (waybill != null)
            {
                if (!string.IsNullOrEmpty(model.RouteStart))
                    waybill.RouteStart = model.RouteStart;
                if (!string.IsNullOrEmpty(model.RouteEnd))
                    waybill.RouteEnd = model.RouteEnd;
                waybill.ClientId = model.ClientId;
                waybill.VehicleId = model.VehicleId;
                waybill.DriverId = model.DriverId;
                waybill.Distance = model.Distance;
                waybill.Date = model.Date;
                context.Waybills.Update(waybill);
                await context.SaveChangesAsync();
            }

            return waybill;
        }

        [Serial]
        public async Task DeleteWaybill(
            [Service] BlogDbContext context, Waybill model)
        {
            var waybill = await context.Waybills.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (waybill != null)
            {
                context.Waybills.Remove(waybill);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Waybill?> InsertWaybill(
            [Service] BlogDbContext context, 
            DateTime date,
            long clientId,
            long vehicleId,
            long driverId,
            string routeStart,
            string routeEnd,
            decimal distance
            )
        {
            var waybill = new Waybill
            {
                Date = date,
                ClientId = clientId,
                VehicleId = vehicleId,
                DriverId = driverId,
                RouteStart = routeStart,
                RouteEnd = routeEnd,
                Distance = distance
            };
            context.Waybills.Add(waybill);
            await context.SaveChangesAsync();
            return waybill;
        }
    }
}