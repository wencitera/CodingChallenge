using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formateador
{
    public class Traductor
    {
        public ResourceManager Resource { get; }

        public enum Lenguajes
        {
            es_ES,
            en_US,
            pt_BR
        }

        public Traductor(Lenguajes lenguaje)
        {
            Resource = new ResourceManager($"CodingChallenge.Data.Resources.{lenguaje}", typeof(Traductor).Assembly);
        }

    }
}
