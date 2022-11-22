using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace ApiPet.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class petController : ControllerBase
    {
        [HttpPost]
        public Models.TbPet SalvarPet(Models.TbPet pet)
        {
            Models.PetDbContext ctx = new Models.PetDbContext();
            ctx.TbPets.Add(pet);
            ctx.SaveChanges();
            return pet;
        }
    }
}