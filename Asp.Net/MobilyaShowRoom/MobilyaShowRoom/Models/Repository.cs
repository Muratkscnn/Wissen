using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class Repository
    {
        public static List<Product> AllProducts()
        {
            var products = new List<Product>
            {
                new Product{ ID=540,ProductName="Sürgülü Dolap 1",ProductDetail="Sürgülü raylı Aynalı dolap 1",Price=4500},
                new Product{ ID=545,ProductName="Sürgülü Dolap 2",ProductDetail="Sürgülü raylı Aynalı dolap 2",Price=5500},
                new Product{ ID=640,ProductName="Sürgülü Dolap 3",ProductDetail="Sürgülü raylı Aynalı dolap 3",Price=6500},
                new Product{ ID=340,ProductName="Sürgülü Dolap 4",ProductDetail="Sürgülü raylı Aynalı dolap 4",Price=7500},
                new Product{ ID=510,ProductName="Sürgülü Dolap 5",ProductDetail="Sürgülü raylı Aynalı dolap 5",Price=8500},
                new Product{ ID=590,ProductName="Sürgülü Dolap 6",ProductDetail="Sürgülü raylı Aynalı dolap 6",Price=9500},

            };
            return products;
        }
    }
}
