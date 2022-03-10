using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNinject
{
    class Program
    {
        public static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IProduct _objIpro = _kernel.Get<IProduct>();
            BL objbl = new BL(_objIpro);
            objbl.Insert();
            Console.ReadLine();
        }
    }
}
