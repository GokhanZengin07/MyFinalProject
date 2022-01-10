using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // static olunca new'Lenmez
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz"; // publicler PascalCase
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed="Ürünler listelendi.";
    }
}
