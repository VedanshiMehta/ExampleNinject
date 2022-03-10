using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNinject
{
    class BL
    {
        IProduct objIPro;
        public BL(IProduct objIProduct)
        {
            objIPro = objIProduct;
        }

        public void Insert()
        {
            objIPro.InsertProduct();
        }
    }
}
