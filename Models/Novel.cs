using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class Novel : Book
    {
        public string Publisher { get; set; }
        public bool Fiction { get; set; }

        public Novel() { }

        public Novel(string _Publisher, bool _Fiction, string _Title, string _Author, double _Price, string _Genre, string _ISBN)
        {
            base.Title = _Title;
            base.Author = _Author;
            base.Price = _Price;
            base.Genre = _Genre;
            base.ISBN = _ISBN;

            this.Publisher = _Publisher;
            this.Fiction = _Fiction;
        }

        public override sealed string GetInfo()
        {
            return $"Author: {Author}</br>Genre: {Genre}</br>Publisger: {Publisher}</br>Fiction: {(Fiction ? "Fiction" : "Non-fiction")}</br>ISBN: {ISBN}</br>Price: R{Price}</br>";
        }

        public override sealed string ToString()
        {
            return "Novel";
        }
    }
}