using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _altura;
        public Rectangulo(decimal ancho, decimal altura) : base(ancho)
        {
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _altura * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return (_altura + _lado) * 2m; 
        }
    }
}
