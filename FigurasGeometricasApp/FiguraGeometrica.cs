public class FiguraGeometrica
{
    // Propiedad común a todas las figuras
    public string Nombre { get; set; }

    // Constructor que recibe el nombre
    public FiguraGeometrica(string nombre)
    {
        Nombre = nombre;
    }

    // Método ToString para mostrar información básica
    public override string ToString()
    {
        return $"Figura: {Nombre}";
    }
}
