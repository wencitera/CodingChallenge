using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Classes.Formateador.Traductor.Lenguajes.es_ES));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Classes.Formateador.Traductor.Lenguajes.en_US));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Classes.Formateador.Traductor.Lenguajes.es_ES);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado (1),
                new Cuadrado (3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Classes.Formateador.Traductor.Lenguajes.es_ES);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }


        //TEST NUEVOS
        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Classes.Formateador.Traductor.Lenguajes.pt_BR));
        }


        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5, 3, 3, 2, 2) };

            var resumen = FormaGeometrica.Imprimir(trapecios, Classes.Formateador.Traductor.Lenguajes.es_ES);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 8 | Perimetro 13 <br/>TOTAL:<br/>1 formas Perimetro 13 Area 8", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var trapecios = new List<FormaGeometrica>
            {
                new Rectangulo(5, 3),
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, Classes.Formateador.Traductor.Lenguajes.es_ES);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosPortugues()
        {
            var trapecios = new List<FormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(2, 4),
                new Rectangulo(3, 6)
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, Classes.Formateador.Traductor.Lenguajes.pt_BR);

            Assert.AreEqual("<h1>Relatório de formulários</h1>3 Retângulos | Area 41 | Perimetro 46 <br/>TOTAL:<br/>3 formas Perimetro 46 Area 41", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosPortugues()
        {
            var trapecios = new List<FormaGeometrica>
            {
                new Trapecio(5, 3, 3, 2, 2),
                new Trapecio(7, 4, 5, 3, 5),
                new Trapecio(3, 1, 2, 1, 1)
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, Classes.Formateador.Traductor.Lenguajes.pt_BR);

            Assert.AreEqual("<h1>Relatório de formulários</h1>3 Trapézios | Area 37.5 | Perimetro 39 <br/>TOTAL:<br/>3 formas Perimetro 39 Area 37.5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortuges()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Trapecio(5, 3, 3, 2, 2),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m),
                new Trapecio(7, 4, 5, 3, 5),
                new Trapecio(3, 1, 2, 1, 1)
            };

            var resumen = FormaGeometrica.Imprimir(formas,Classes.Formateador.Traductor.Lenguajes.pt_BR);

            Assert.AreEqual(
                "<h1>Relatório de formulários</h1>2 Quadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triângulos | Area 49.64 | Perimetro 51.6 <br/>3 Trapézios | Area 37.5 | Perimetro 39 <br/>TOTAL:<br/>10 formas Perimetro 136.66 Area 129.15", 
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnHexagono()
        {
            var hexagonos = new List<FormaGeometrica>
            {
                new HexagonoEquilatero(6),
            };

            var resumen = FormaGeometrica.Imprimir(hexagonos, Classes.Formateador.Traductor.Lenguajes.es_ES);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Hexágono | Area 93.53 | Perimetro 36 <br/>TOTAL:<br/>1 formas Perimetro 36 Area 93.53", resumen);
        }
    }
}
