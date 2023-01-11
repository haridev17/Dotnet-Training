class Triangle : Shape
{
    public int Hypertenuese { get; set; }
    public double CalculateArea()
    {
        return 0.5 * Width * Height;
    }
}