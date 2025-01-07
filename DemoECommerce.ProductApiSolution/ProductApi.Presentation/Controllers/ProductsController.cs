using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Aplication.Interfaces;

namespace ProductApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProduct productInterface) : ControllerBase
    {
    }
}
