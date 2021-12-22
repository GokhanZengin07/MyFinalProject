using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{   // Class infertace veya inherentace almıyorsa tekrar dön bak 
    // Concrete içerisindekiler bir veritabınana karşılık geliyor.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
