using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mycontroller : Controller
    {

        private comicbookrepository _comicbookrepository = null;

        public mycontroller(){

                _comicbookrepository=new comicbookrepository();
                
        } 

        public ActionResult Index()
        {
            var comicBooks = _comicbookrepository.GetComicBooks();
            return View(comicBooks);
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicbookrepository.GetComicBook(id.Value);
        
            return View(comicBook);
        }
    }
}