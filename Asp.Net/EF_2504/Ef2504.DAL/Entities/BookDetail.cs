﻿namespace Ef2504.DAL.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public string BookDetailISBN { get; set; }
        public string BookDetailCity { get; set; }
        public string BookDetailCountry { get; set; }
        public int BookDetailYear { get; set; }

    }
}