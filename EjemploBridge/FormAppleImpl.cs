using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBridge
{
    public class FormAppletImpl : FormularioImpl
    {

        public void dibujaTexto(string texto)
        {
            Console.WriteLine("Applet: " + texto);
        }

        public string administraZonaIndicada()
        {
            return Console.ReadLine();
        }
    }
}
