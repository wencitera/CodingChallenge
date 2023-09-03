using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _altura;
        private readonly decimal _lateralA;
        private readonly decimal _lateralB;
        public Trapecio(decimal baseMenor, decimal baseMayor, decimal lateralA, decimal lateralB, decimal altura) : base(baseMenor)
        {
            _baseMayor = baseMayor;
            _altura = altura;
            _lateralA = lateralA;
            _lateralB = lateralB;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _lado) * _altura / 2m;
        }

        public override decimal CalcularPerimetro()
        {
            return _lateralA + _lateralB + _baseMayor + _lado;
        }
    }
}
