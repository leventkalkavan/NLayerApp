using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayer.Core.Model;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{
    public class CategoriesController : ControllerBase
    {
        [HttpGet("[action]")]
        public async IActionResult GetSingleCategoryByIdWithProduct(int categoryId)
        {
            
        }
    }
}
