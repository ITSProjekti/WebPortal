

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortal.Models;
using WebPortal.ViewModels;
using System.Data.Entity;

namespace WebPortal.Content.uploads
{
    /// <summary>
    /// Kontroler za upravljanje ucenicima.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class UploadMaterijalController : Controller
    {
        /// <summary>
        /// Deklaracija polja context.
        /// </summary>
        private IMaterijalContext context;

        /// <summary>
        /// Inicijalizuje instancu klase <see cref="UploadMaterijalController"/>.
        /// </summary>
        public UploadMaterijalController()
        {
            context = new MaterijalContext();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMaterijalController"/> class.
        /// </summary>
        /// <param name="Context">The context.</param>
        public UploadMaterijalController(IMaterijalContext Context)
        {
            context = Context;
        }



        /// <summary>
        /// Funkcija koja sluzi za prikaz materijala.
        /// </summary>
        /// <param name="Broj">Broj.</param>
        /// <returns>View</returns>
        [HttpGet]
        public ActionResult MaterijaliPrikaz(int number = 0)
        {
            List<MaterijalModel> materijali;
            materijali = context.materijali.ToList();
            if (number == 0)
            {
                materijali = context.materijali.ToList();
            }
            else
            {
                materijali = (from p in context.materijali
                              select p).Take(number).ToList();
            }

            return View("MaterijaliPrikaz", materijali);

        }

        [HttpGet]
        public ActionResult UploadMaterijal()
        {


            return View();
        }

        /// <summary>
        /// Funkcija koja sluzi za upload materijala.
        /// </summary>
        /// <param name="materijal">Materijal.</param>
        /// <param name="file">Fajl.</param>
        /// <returns>View</returns>
        [HttpPost]
        public ActionResult UploadMaterijal(MaterijalModel materijal, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (file != null)
                {


                    string nazivFajla = Path.GetFileName(file.FileName);

                    materijal.fileMimeType = file.ContentType;
                    materijal.materijalFile = new byte[file.ContentLength];
                    file.InputStream.Read(materijal.materijalFile, 0, file.ContentLength);
                    materijal.materijalNaziv = nazivFajla;
                    materijal.materijalEkstenzija = Path.GetExtension(nazivFajla);

                }

                ViewBag.Message = "Uspešno ste postavili materijal!";
                context.Add<MaterijalModel>(materijal);
                context.SaveChanges();
                return View();
            }
            else
            {
                ViewBag.Message = "Postavljanje materijala nije uspelo!";
                return View();
            }
        }

        /// <summary>
        /// Funkcija koja sluzi za download materijala.
        /// </summary>
        /// <param name="id">Identifikator.</param>
        /// <returns>File</returns>
        public FileContentResult DownloadMaterijal(int id)
        {
            MaterijalModel materijal = context.pronadjiMaterijalPoId(id);
            if (materijal != null)
            {
                return File(materijal.materijalFile, materijal.fileMimeType, materijal.materijalNaziv);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Funkcija koja sluzi za brisanje materijala.
        /// </summary>
        /// <param name="id">Identifikator.</param>
        /// <returns>View</returns>
        public ActionResult Delete(int id)
        {
            MaterijalModel materijal = context.pronadjiMaterijalPoId(id);
            if (materijal == null)
            {
                return HttpNotFound();
            }
            return View("Delete", materijal);
        }

        /// <summary>
        /// Funkcija koja sluzi za brisanje materijala nakon sto je potvrdjeno.
        /// </summary>
        /// <param name="id">Identifikator</param>
        /// <returns>RedirectToAction</returns>
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MaterijalModel materijal = context.pronadjiMaterijalPoId(id);
            context.Delete<MaterijalModel>(materijal);
            context.SaveChanges();
            return RedirectToAction("MaterijaliPrikaz");
        }
    }
}