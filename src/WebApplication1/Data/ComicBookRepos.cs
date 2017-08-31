using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class comicbookrepository
    {
        private static model1[] model1s = new model1[] {
    new model1()
    {
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 700,
        DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
            new Artist() { Name = "Victor Olazaba", Role = "Inks" },
            new Artist() { Name = "Edgar Delgado", Role = "Colors" },
            new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
        },
        Favorite = false
    },
    new model1()
    {
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 657,
        DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Marcos Martin", Role = "Pencils" },
            new Artist() { Name = "Marcos Martin", Role = "Inks" },
            new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
            new Artist() { Name = "Joe Caramagna", Role = "Letters" }
        },
        Favorite = false
    },
    new model1()
    {
        SeriesTitle = "Bone",
        IssueNumber = 50,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorite = false
    }
};
        public class ComicBookRepos
        {

            public model1 GetComicBook(int id)
            {
                model1 comicBookToReturn = null;
                foreach (var comicbook in model1s)
                {
                    if (comicbook.Id == id)
                    {
                        comicBookToReturn = comicbook;
                        break;
                    }
                }
                return comicBookToReturn;
            }
        }
    }
}