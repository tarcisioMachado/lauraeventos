using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProLaura.Api.Data;
using ProLaura.Api.Models;



namespace ProLaura.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        private readonly DataContext _context;
        
        public EventosController(DataContext context)
        {
            _context = context;
           
        }
        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _context.Evetos;
        }
         [HttpGet("{id}")]
        public Evento GetById(int id){
            return _context.Evetos.FirstOrDefault(evento => evento.EventoId ==id);
            
        }
                
        
      
      
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
         [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }
         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id ={id}";
        }

       

    }
}
