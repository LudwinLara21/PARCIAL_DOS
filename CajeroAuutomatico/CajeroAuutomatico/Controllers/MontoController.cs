using CajeroAuutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroAuutomatico.Controllers
{
    public class MontoController : Controller
    {
        // GET: Monto
        public ActionResult Index()
        {
            return View();
        }
    }
    
    public ActionResult index (ModeloGeneral K)
    {
        _ = K;

        if (K.Monto % 5==0)
     
        {
            return View("SI");
           
        }
        return View("NO");
        

      
    }
    public ActionResult SI()
        {

        {
            return View();
        }



    }
    public ActionResult NO()

    {
        {
            return View();
        }
    }
}


