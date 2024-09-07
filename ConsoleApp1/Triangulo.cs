using System;

public class Triangulo : Figura
{
    private float Base_Triangulo;
    private float Altura_Triangulo;

    public Triangulo(float Base_Triangulo, float Altura_Triangulo)
    {
        this.Base_Triangulo = Base_Triangulo;
        this.Altura_Triangulo = Altura_Triangulo;
    }

    public override float CalcularArea()
    {
        return (Base_Triangulo * Altura_Triangulo) / 2;
    }
}