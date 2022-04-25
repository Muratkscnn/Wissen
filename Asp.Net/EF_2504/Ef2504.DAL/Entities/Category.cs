using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef2504.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategorName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Book> Books { get; set; }

    }
}
