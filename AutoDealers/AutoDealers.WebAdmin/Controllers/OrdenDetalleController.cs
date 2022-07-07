using AutoDealers.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoDealers.WebAdmin.Controllers
{
    public class OrdenDetalleController : Controller
    {
        OrdenesBL _ordenBL;
        ProductosBL _productosBL;

        public OrdenDetalleController()
        {
            _ordenBL = new OrdenesBL();
            _productosBL = new ProductosBL();
        }

        // GET: OrdenDetalle
        public ActionResult Index(int id)
        {
            var orden = _ordenBL.ObtenerOrdenes(id);

            return View();
        }

        public ActionResult Crear(int id)
        {
            var nuevaOrdenDetalle = new OrdenDetalle();
            nuevaOrdenDetalle.OrdenId = id;

            var productos = _productosBL.ObtenerProductos();
            ViewBag.ProductoId = new SelectList(productos, "Id", "Descripcion");

            return View(nuevaOrdenDetalle);
        }

        [HttpPost]
        public ActionResult Crear(OrdenDetalle ordenDetalle)
        {
            if (ModelState.IsValid)
            {
                if (ordenDetalle.ProductoId == 0)
                {
                    ModelState.AddModelError("ProductoId", "Selecione un Producto");
                    return View(ordenDetalle);
                }

                _ordenBL.GuardarOrdenDetalle(ordenDetalle);
                return RedirectToAction("Index", new { Id = ordenDetalle.OrdenId });
            }

            

            var productos = _productosBL.ObtenerProductos();

            ViewBag.ProductoId = new SelectList(productos, "Id", "Descripcion");
            return View(ordenDetalle);

        }
       
    }
}