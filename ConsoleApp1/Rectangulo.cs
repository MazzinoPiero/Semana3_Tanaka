using System;

public class Rectangulo : Figura
{
    private float Base_Rectangulo;
    private float Altura_Rectangulo;

    public Rectangulo(float Base_Rectangulo, float Altura_Rectangulo)
    {
        this.Base_Rectangulo = Base_Rectangulo;
        this.Altura_Rectangulo = Altura_Rectangulo;
    }

    public override float CalcularArea()
    {
        return Base_Rectangulo * Altura_Rectangulo;
    }
}