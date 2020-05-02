using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Select()
        {
           ViewData["Video"] = BaseHelper.ejecutarConsulta(
                "SELECT * FROM video", CommandType.Text);
            return View();
        }

        public ActionResult Create()
        {
            ViewData["video"] = BaseHelper.ejecutarConsulta(
                   "SELECT * FROM video", CommandType.Text);
            return View();
        }

        [HttpPost]
        public ActionResult Create(int IdVideo,
                                   string titulo, 
                                   int reproduccion, 
                                   string Url)
        {

            //guardar datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproduccion", reproduccion));
            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.ejecutarSentencia("sp_video_Create", CommandType.StoredProcedure,parametros);

            return View("Agregado");
        }

        public ActionResult Agregado()
        {
            return View();
        }


        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(int IdVideo,
                                   string titulo,
                                   int reproduccion,
                                   string Url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproduccion", reproduccion));
            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.ejecutarSentencia("sp_video_update", CommandType.StoredProcedure, parametros);

            return View("Modificado");
        }

        public ActionResult Modificado()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int IdVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            BaseHelper.ejecutarSentencia("sp_video_Delete", CommandType.StoredProcedure, parametros);

            return View("Eliminado");
        }
        public ActionResult Eliminado()
        {
            return View();
        }
    }
}
