using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mycontroller : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new model1()
            {
                SeriesTitle = "The loser Spider Man",
                IssueNumber=700,
                DescriptionHtml = "<p> Final issue!Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists=new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name="Humberto Ramos",Role="Pencils"},
                    new Artist() {Name="Victor Olazaba",Role="inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Chris Bosh",Role="Letters"},
                }
            };
        
            return View(comicBook);
        }
    }
}