using System;
using System.Collections.Generic;

namespace Ef2504.DAL.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFullName => string.Concat(AuthorFirstName,"",AuthorLastName);
        public DateTime AuthorCreatedDate { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }

    }
}
