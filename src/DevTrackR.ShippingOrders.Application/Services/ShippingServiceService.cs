using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTrackR.ShippingOrders.Application.ViewModels;
using DevTrackR.ShippingOrders.Core.Entities;
using DevTrackR.ShippingOrders.Core.Repositories;

namespace DevTrackR.ShippingOrders.Application.Services
{
    public class ShippingServiceService : IShippingServiceService
    {
        private readonly IShippingServiceRepository _repository;

        public ShippingServiceService(IShippingServiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ShippingServiceViewModel>> GetAll()
        {
            /*
            var shippingServices = new List<ShippingService> {
                new ShippingService("Selo", 0, 1.2m),
                new ShippingService("Envio com Registro", 2.2m, 5.0m),
                new ShippingService("Envio sem Registro", 1.0m, 3.0m),
            };

            return Task.FromResult(
                shippingServices
                    .Select(s => new ShippingServiceViewModel(s.Id, s.Title, s.PricePerKg, s.FixedPrice))
                    .ToList()
            );*/
            var shippingServices = await _repository.GetAllAsync();

            return shippingServices
                .Select(s => new ShippingServiceViewModel(s.Id, s.Title, s.PricePerKg, s.FixedPrice))
                .ToList();
        }
    }
}