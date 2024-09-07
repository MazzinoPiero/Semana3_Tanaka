using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Selecciona una figura para calcular el área:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Círculo");
            Console.WriteLine("4. Triángulo");
            Console.WriteLine("5. Salir");
            Console.Write("Ingresa el número de la figura: ");

            int opcion = int.Parse(Console.ReadLine());

            Figura figura = null;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa la base del rectángulo: ");
                    float Base_Rectangulo = float.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del rectángulo: ");
                    float Altura_Rectangulo = float.Parse(Console.ReadLine());
                    figura = new Rectangulo(Base_Rectangulo, Altura_Rectangulo);
                    break;

                case 2:
                    Console.Write("Ingresa el lado del cuadrado: ");
                    float lado_cuadrado = float.Parse(Console.ReadLine());
                    figura = new Cuadrado(lado_cuadrado);
                    break;

                case 3:
                    Console.Write("Ingresa el radio del círculo: ");
                    float radio = float.Parse(Console.ReadLine());
                    figura = new Circulo(radio);
                    break;

                case 4:
                    Console.Write("Ingresa la base del triángulo: ");
                    float Base_Triangulo = float.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del triángulo: ");
                    float Altura_Triangulo = float.Parse(Console.ReadLine());
                    figura = new Triangulo(Base_Triangulo, Altura_Triangulo);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Error opción no válida e inexistente.");
                    continue;
            }

            if (figura != null)
            {
                float area = figura.CalcularArea();
                Console.WriteLine($"El área de la figura es: {area}");
            }

            Console.WriteLine("¿Desea seleccionar otra figura? Si o no donde "s" es si y "n" es no (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                break;
            }
        }
    }
}
