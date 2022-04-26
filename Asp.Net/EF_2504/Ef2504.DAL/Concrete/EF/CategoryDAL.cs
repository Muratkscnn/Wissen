using Ef2504.DAL.Abstract;
using Ef2504.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef2504.DAL.Concrete.EF
{
    public class CategoryDAL : EFBaseRepository<Category> , IEntityRepository<Category>, ICategoryDAL
    {

    }
}
