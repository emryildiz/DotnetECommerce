using DotnetEcommerce.Entities;
using DotnetEcommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetECommerce.Controllers;
[ApiController]
[Route("apis/[controller]s")]
public class AdressController : ControllerBase
{
    private readonly AdressService adressService;
    public AdressController(AdressService addressService) => this.adressService = addressService;

    [HttpGet]
    public List<Adress> GetAll()
    {
        return adressService.GetAll().ToList();
    }
}