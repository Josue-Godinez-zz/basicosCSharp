using System;

namespace basicosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoActual = Convert.ToInt32("2019");
            double numeroPi = 3.141592;
            Console.WriteLine("Valores:{0} -- {1}", añoActual, numeroPi);
            decimal montoFactura = 94593.34m + 0.07m;
            float impuestoVenta = 9239.04f;
            Console.WriteLine("Valores:{0} -- {1}", montoFactura, impuestoVenta);
            char letraInicial = 'P';
            string nombreCurso = letraInicial + "rogramacion II";
            Console.WriteLine(nombreCurso);
            bool boolVerdadero = true;
            bool boolFalso = false;
            Console.WriteLine("Variables boleanas: {0} y {1}", boolVerdadero, boolFalso);

            double resultadoSuma = 540 + -18.5;
            float resultadoResta = 3458.35f - 334.34f;
            decimal resultadoMultiplicacion = 23.423m * 3423m;
            decimal resultadoDivision = 239.42m / 0.3m;
            decimal resultadoResiduo = 2321.42m % 23m;
            double resultaddoPotencia = Math.Pow(72, 2);
            double resultadoRaiz = Math.Sqrt(144);

            //sadfsfgdf

            int primerNumero = 48;
            int segundoNumero = 12;
            primerNumero += segundoNumero;
            primerNumero -= segundoNumero;
            primerNumero *= segundoNumero;
            primerNumero /= segundoNumero;
            primerNumero %= segundoNumero;
            primerNumero++;
            primerNumero--;


        }
    }
}
