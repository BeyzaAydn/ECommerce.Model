using ECommerce.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Entities
{
    public  class Product:BaseEntity
    {

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }


        //Mapping
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}
