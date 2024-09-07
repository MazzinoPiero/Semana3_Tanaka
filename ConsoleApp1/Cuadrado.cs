using System;

public class Cuadrado : Figura
{
    private float lado_cuadrado;

    public Cuadrado(float lado_cuadrado)
    {
        this.lado_cuadrado = lado_cuadrado;
    }

    public override float CalcularArea()
    {
        return lado_cuadrado * lado_cuadrado;
    }
}