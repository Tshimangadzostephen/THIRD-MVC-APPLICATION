using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class TextBook : Book
    {
        public string Subject { get; set; }
        public int Edition { get; set; }

        public TextBook() { }

        public TextBook(int _Edition, string _Subject, string _Title, string _Author, double _Price, string _Genre, string _ISBN)
        {
            base.Title = _Title;
            base.Author = _Author;
            base.Price = _Price;
            base.Genre = _Genre;
            base.ISBN = _ISBN;

            this.Edition = _Edition;
            this.Subject = _Subject;
        }

        public override sealed string GetInfo()
        {
            return $"Author: {Author}</br>Genre: {Genre}</br>Edition: {Edition}</br>Subject: {Subject}</br>ISBN: {ISBN}</br>Price: R{Price}</br>";
        }

        public override sealed string ToString()
        {
            return "TextBook";
        }
    }
}