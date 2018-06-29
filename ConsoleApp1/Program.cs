using ClassLibrary1.Model.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                ContextFluent context = new ContextFluent();
                context.SaveChanges();
            }
            catch (Exception e)
            {

            }

        }
    }
}
