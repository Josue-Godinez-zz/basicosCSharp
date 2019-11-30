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
        }
    }
}
