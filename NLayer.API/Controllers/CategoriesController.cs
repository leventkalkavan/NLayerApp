using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Model;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;
        private readonly IProductService productService;
    }
}
