﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SALESCAR.API.Model;

namespace SALESCAR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrosController : ControllerBase
    {
        public IEnumerable<Carro> _carro = new Carro [] {
                new Carro () {
                    CarroId = 1,
                    Descricao = "Palio",
                    Marca = "Fiat",
                    Cor = "Vermelha",
                    AnoFabricacao = "2010",
                    AnoModelo = "2010"
                },
                new Carro () {
                    CarroId = 2,
                    Descricao = "Gol",
                    Marca = "Volkswagen",
                    Cor = "Vermelha",
                    AnoFabricacao = "2010",
                    AnoModelo = "2010"
                },
                new Carro () {
                    CarroId = 3,
                    Descricao = "HB20",
                    Marca = "Hiundai",
                    Cor = "Vermelha",
                    AnoFabricacao = "2010",
                    AnoModelo = "2010"
                }
            };

        public CarrosController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Carro> Get()
        {
            return _carro;
        }

        [HttpGet("{id}")]
        public IEnumerable<Carro> GetById(int id)
        {
            return _carro.Where(carro => carro.CarroId == id);
        }
    }
}
