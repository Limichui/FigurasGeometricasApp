public class Rectangulo : FiguraGeometrica, IPoligono
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto) : base("Rectángulo")
    {
        Ancho = ancho;
        Alto = alto;
    }

    public double Area(double ancho, double alto)
    {
        return ancho * alto;
    }

    public override string ToString()
    {
        return $"{Nombre} - Área: {Ancho} * {Alto} = {Area(Ancho, Alto):F2}";
    }
}
