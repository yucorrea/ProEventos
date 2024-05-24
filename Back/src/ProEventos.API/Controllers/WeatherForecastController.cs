using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "React Native",
                Local = "RJ",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.UtcNow.AddDays(2).ToString(),
                ImageURL = "example.jpg"
           },
            new Evento() {
                EventoId = 2,
                Tema = "ReactJS",
                Local = "SP",
                Lote = "2 Lote",
                QtdPessoas = 100,
                DataEvento = DateTime.UtcNow.AddDays(2).ToString(),
                ImageURL = "example2.jpg"
           }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
