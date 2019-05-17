using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Motos_Motores.Data;

namespace Motos_Motores.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {


        private readonly ApplicationDbContext _context;

        public InventarioController(ApplicationDbContext context) {

             _context = context;
        }
        public IActionResult Index()
        {
            var DataVentas = _context.Ventas.GroupBy(x => x.Producto).ToList();
            var DataCompras = _context.Compras.ToList();
            //var Data = 
           

            return View();
        }
    }
}