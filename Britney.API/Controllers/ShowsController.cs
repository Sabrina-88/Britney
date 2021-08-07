using System;
using System.Collections.Generic;
using System.Linq;
using Britney.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Britney.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // essa é a rota da api
    public class ShowsController : ControllerBase
    {
        [HttpGet]
        public ShowModel Get()
        {
            return new ShowModel(){
                   
            };
        }
         [HttpGet]
   /*  public IEnumerable<ShowModel> Get()
    {
        return _context.Eventos;
    }

     [HttpGet("{id}")]

     public ShowModel GetById(int id) //retornar só o obj sem array
    {
        return _context.Eventos.FirstOrDefault(
            evento => evento.EventoId == id);
        
    }
    */
    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }

}
}
   