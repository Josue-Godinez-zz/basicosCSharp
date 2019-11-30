using System;

public class CalculadoraBasica
{

    private double ultimoResultado;
    public CalculadoraBasica()
    {
    }

    public double Sumar(double primerValor, double segundoValor)
    {
        ultimoResultado = primerValor + segundoValor;
        return ultimoResultado;
    }
    public double Dividir(double primerValor, double segundoValor)
    {
        return primerValor / segundoValor;
    }
}
