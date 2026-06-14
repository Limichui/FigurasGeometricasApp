using System;

public class Elipse : FiguraGeometrica, IPoligono
{
    public double RadioMayor { get; set; }
    public double RadioMenor { get; set; }

    // Constructor que recibe los valores desde el formulario
    public Elipse(double radioMayor, double radioMenor) : base("Elipse")
    {
        RadioMayor = radioMayor;
        RadioMenor = radioMenor;
    }

    public double Area(double radioMayor, double radioMenor)
    {
        return Math.PI * radioMayor * radioMenor;
    }

    public override string ToString()
    {
        return $"{Nombre} - Área: PI * {RadioMenor} * {RadioMayor} = {Math.Round(Area(RadioMayor, RadioMenor),2)}";
    }
}