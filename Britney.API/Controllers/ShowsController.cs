using System;
using System.Collections.Generic;
using System.Linq;
using Britney.API.Data;
using Britney.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Britney.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // essa é a rota da api
    public class ShowsController : ControllerBase
    {
        private readonly DataContext _context;
        public ShowsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<ShowModel> Get()
        {
            return _context.ShowsDataBase;
        }

        [HttpGet("{id}")]
        public ShowModel GetById(int id)
        {
            return _context.ShowsDataBase.FirstOrDefault(show => show.ShowId == id);
            //onde é passado um evento e o id desse evento for igual ao id passado pelo parametro
        }
        //se quiser retornar dentro de um array
        // public IEnumerable<Evento> GetById(int id)
        // {
        //     return _context.Eventos.Where(evento => evento.EventoId == id);
        //     //onde é passado um evento e o id desse evento for igual ao id passado pelo parametro
        // }



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
