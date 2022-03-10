using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNinject
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public NinjectBindings()
        {
        }

        public override void Load()
        {
            Bind<IProduct>().To<DL>();
        }
    }
}
