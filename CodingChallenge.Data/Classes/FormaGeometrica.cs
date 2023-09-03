/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using Castle.Components.DictionaryAdapter;
using Castle.Core.Internal;
using CodingChallenge.Data.Classes.Formateador;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using static CodingChallenge.Data.Classes.Formateador.Traductor;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {

        protected readonly decimal _lado;

        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, Lenguajes idioma = Lenguajes.en_US)
        {
            var sb = new StringBuilder();

            //Idioma inicializado en Inglés por default.
            var formateador = new Traductor(idioma);
            if (!formas.Any())
            {
                sb.Append($"<h1>{formateador.Resource.GetString("lista_vacia")}</h1>");
            }
            else
            {

                sb.Append($"<h1>{formateador.Resource.GetString("reporte")}</h1>");

                var formasAgrupadas = formas.GroupBy(g => g.GetType()).Select(s => new { 
                    s.Key.Name,
                    Cantidad = s.Count(),
                    Area = s.Sum(a => a.CalcularArea()),
                    Perimetro = s.Sum(p => p.CalcularPerimetro()),
                });

                foreach (var item in formasAgrupadas)
                {
                    sb.Append(ObtenerLinea(item.Cantidad, item.Area, item.Perimetro, item.Name, formateador.Resource));
                }

                // FOOTER
                sb.Append($"{formateador.Resource.GetString("total")}:<br/>");
                sb.Append($"{formas.Count()} {formateador.Resource.GetString("formas")} ");
                sb.Append($"{formateador.Resource.GetString("perimetro")} {formasAgrupadas.Sum(s => s.Perimetro):#.##} ");
                sb.Append($"{formateador.Resource.GetString("area")} {formasAgrupadas.Sum(s => s.Area):#.##}");
            }

            return sb.ToString();
        }


        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, ResourceManager resource)
        {
            if (cantidad > 0)
            {
               return $"{cantidad} {TraducirForma(tipo, cantidad, resource)} | {resource.GetString("area")} {area:#.##} | {resource.GetString("perimetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(string tipo, int cantidad, ResourceManager resource)
        {
            var nombreForma = tipo.ToLower();
            return cantidad == 1 ? resource.GetString(nombreForma) : resource.GetString($"{nombreForma}s");
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
