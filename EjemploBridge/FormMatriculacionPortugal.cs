using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBridge
{
    public class FormularioMatriculacionPortugal :
  FormularioMatriculación
    {
        public FormularioMatriculacionPortugal(FormularioImpl
        implementacion) : base(implementacion) { }

        protected override bool controlZona(string matricula)
        {
            return matricula.Length == 6;
        }
    }
}
