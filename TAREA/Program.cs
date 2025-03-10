using System;

// Clase base
public class Ave
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    
    public Ave(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }
    
    // Método virtual que será sobrescrito
    public virtual void Volar()
    {
        Console.WriteLine("Algunas aves pueden volar.");
    }
    
    // Método virtual
    public virtual void HacerSonido()
    {
        Console.WriteLine("Algunas aves hacen sonidos específicos.");
    }
}

// Clase derivada 1
public class Aguila : Ave
{
    public Aguila(string nombre, string color) : base(nombre, color) { }

    public override void Volar()
    {
        Console.WriteLine("El águila vuela alto y rápido.");
    }
    public override void HacerSonido()
    {
        Console.WriteLine("El águila emite un grito fuerte.");
    }
}

// Clase derivada 2
public class Canario : Ave
{
    public Canario(string nombre, string color) : base(nombre, color) { }

    public override void Volar()
    {
        Console.WriteLine("El canario vuela en pequeñas distancias.");
    }
    public override void HacerSonido()
    {
        Console.WriteLine("El canario canta melodiosamente.");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        Ave ave1 = new Aguila("Águila Real", "Marrón");
        Ave ave2 = new Canario("Canario Amarillo", "Amarillo");
        
        ave1.Volar();
        ave1.HacerSonido();
        
        Console.WriteLine();
        
        ave2.Volar();
        ave2.HacerSonido();
    }
}
