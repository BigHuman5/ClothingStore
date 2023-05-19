
using ClothingStore.BLL.Interfaces;
using ClothingStore.Models.Brands;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Controllers
{
    public class BrandsController : ApiController
    {
        private IBrandsServices services;

        public BrandsController(IBrandsServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All(int orderBy=0)
        {
            var result = await new BrandsProductBuilder(this.services).BuildAll();

            if(result==null || result.Count()==0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet]
        [ActionName("sv")]
        public async Task<ActionResult> SetVisible(int? id=null)
        {
            if(ModelState.IsValid)
            {
                if(id==null)
                {
                    return BadRequest("Id не указан");
                }
                return Ok("fd"+id);
            }
            return BadRequest();
        }
    }
}
