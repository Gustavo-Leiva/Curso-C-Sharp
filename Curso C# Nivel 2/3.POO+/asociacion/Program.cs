using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asociacion: puede ser composicion y agregacion.

            //IMPORTANTE 
            /*
             * La relacion de clase se le como ES, ejemplo es un auto, es una animal.
             * La composicion se lee como tiene,TIENE. ejemplo tiene un motor, tiene un chasis.
             * 
             * 
             */

            Auto a1 = new Auto(); //creo el objeto auto.
            a1.Motor = new Motor(); //esto es asociacion por agregacion porque cree un auto y luego le agrego el objeto motor.

            Console.ReadKey();

        }
    }
}
