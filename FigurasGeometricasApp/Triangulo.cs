public class Triangulo : FiguraGeometrica, IPoligono
{
    public double BaseT { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseT, double altura) : base("Triángulo")
    {
        BaseT = baseT;
        Altura = altura;
    }

    public double Area(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }

    public override string ToString()
    {
        return $"{Nombre} - Área: ({BaseT} * {Altura}) / 2 = {Area(BaseT, Altura):F2}";
    }
}
