using System;

public class Circulo : Figura
{
    private float radio;

    public Circulo(float radio)
    {
        this.radio = radio;
    }

    public override float CalcularArea()
    {
        return 3.14f * radio * radio;
    }
}