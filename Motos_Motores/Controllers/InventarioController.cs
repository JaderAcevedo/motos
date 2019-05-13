﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Motos_Motores.Data;

namespace Motos_Motores.Controllers
{
    public class InventarioController : Controller
    {


        private readonly ApplicationDbContext _context;

        public InventarioController(ApplicationDbContext context) {

             _context = context;
        }
        public IActionResult Index()
        {
            var Data = _context.Ventas.ToList();

            return View();
        }
    }
}