using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pangea.Models;

namespace Pangea.Controllers
{
    public class TrabajadorController : Controller
    {
        private PangeaEntities db = new PangeaEntities();

        // GET: Trabajador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_rol,id_sucursal,Nombre,Apellido1,Apellido2,telefono1,telefono2,email,habilitado,id_trabajador_crea,fecha_crea,id_trabajador_modif,fecha_modif")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                db.Trabajador.Add(trabajador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabajador);
        }
    }
}