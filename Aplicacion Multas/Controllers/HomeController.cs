using Aplicacion_Multas.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Aplicacion_Multas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {  
            List<Multa> multas = this.GetMultasPredeterminadas();

           ViewData["Multas"] = multas;
            return View();
        }


        private List<Multa> GetMultasPredeterminadas()
        {
            List<Multa> multas = new List<Multa>();
            multas.Add(new Multa()
            {
                DNI = 41584045,
                FechaDeInfraccion = new DateTime(2020, 10, 10).Date,
                Importe = 1500,
                FechaDePagoDeInfraccion = null,
                Id = 0
            });
            multas.Add(new Multa()
            {
                DNI = 41584045,
                FechaDeInfraccion = new DateTime(2021, 12, 20).Date,
                Importe = 4231,
                FechaDePagoDeInfraccion = null,
                Id = 1
            });
            multas.Add(new Multa()
            {
                DNI = 41584045,
                FechaDeInfraccion = new DateTime(2005, 11, 13).Date,
                Importe = 645,
                FechaDePagoDeInfraccion = null,
                Id = 2
            });
            multas.Add(new Multa()
            {
                DNI = 41584045,
                FechaDeInfraccion = new DateTime(1999, 10, 15).Date,
                Importe = 2354,
                FechaDePagoDeInfraccion = null,
                Id = 3
            });
            multas.Add(new Multa()
            {
                DNI = 41584045,
                FechaDeInfraccion = new DateTime(2021, 10, 31).Date,
                Importe = 2352,
                FechaDePagoDeInfraccion = null,
                Id = 4
            });
            multas.Add(new Multa()
            {
                DNI = 10303456,
                FechaDeInfraccion = new DateTime(2020, 10, 13).Date,
                Importe = 7653,
                FechaDePagoDeInfraccion = null,
                Id = 5
            });
            multas.Add(new Multa()
            {
                DNI = 10303456,
                FechaDeInfraccion = new DateTime(2010, 10, 15).Date,
                Importe = 3451,
                FechaDePagoDeInfraccion = null,
                Id = 6
            });
            multas.Add(new Multa()
            {
                DNI = 10303456,
                FechaDeInfraccion = new DateTime(2014, 10, 16).Date,
                Importe = 2351,
                FechaDePagoDeInfraccion = null,
                Id = 7
            });
            multas.Add(new Multa()
            {
                DNI = 23098641,
                FechaDeInfraccion = new DateTime(2001, 12, 15).Date,
                Importe = 5236,
                FechaDePagoDeInfraccion = null,
                Id = 8
            });
            multas.Add(new Multa()
            {
                DNI = 23098641,
                FechaDeInfraccion = new DateTime(2008, 01, 28).Date,
                Importe = 5324,
                FechaDePagoDeInfraccion = null,
                Id = 9
            });
            multas.Add(new Multa()
            {
                DNI = 23098641,
                FechaDeInfraccion = new DateTime(2012, 11, 25).Date,
                Importe = 2087,
                FechaDePagoDeInfraccion = null,
                Id = 10
            });
            multas.Add(new Multa()
            {
                DNI = 54376423,
                FechaDeInfraccion = new DateTime(2010, 11, 29).Date,
                Importe = 3462,
                FechaDePagoDeInfraccion = null,
                Id = 11
            });
            multas.Add(new Multa()
            {
                DNI = 54376423,
                FechaDeInfraccion = new DateTime(2019, 07, 12).Date,
                Importe = 2531,
                FechaDePagoDeInfraccion = null,
                Id = 12
            });
            multas.Add(new Multa()
            {
                DNI = 54376423,
                FechaDeInfraccion = new DateTime(2021, 10, 31).Date,
                Importe = 5346,
                FechaDePagoDeInfraccion = null,
                Id = 13
            });
            multas.Add(new Multa()
            {
                DNI = 11089345,
                FechaDeInfraccion = new DateTime(2000, 05, 12).Date,
                Importe = 8763,
                FechaDePagoDeInfraccion = null,
                Id = 14
            });

            return multas;
        }       
    }
}
