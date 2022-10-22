using DevTrackR.ShippingOrders.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.ShippingOrders.API.Controllers
{
    [ApiController]
    [Route("api/shipping-services")]
    public class ShippingServicesController : ControllerBase
    {
        private readonly IShippingServiceService _service;

        public ShippingServicesController(IShippingServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var shippingService = await _service.GetAll();
            
            return Ok(shippingService);
        }
    }
}