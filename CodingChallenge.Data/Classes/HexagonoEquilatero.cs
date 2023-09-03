using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class HexagonoEquilatero : FormaGeometrica
    {
        public HexagonoEquilatero(decimal ancho) : base(ancho)
        {
        }

        public override decimal CalcularArea()
        {
            return 3 * Convert.ToDecimal(Math.Sqrt(3)) * _lado * _lado / 2m;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 6;
        }
    }
}
