namespace CircleCalculator.Models;

public class CircleModel
{
    public double Radius { get; set; }
    public double DienTich => Math.PI * Radius * Radius;
    public double ChuVi => 2 * Math.PI * Radius;
    public double DuongKinh => 2 * Radius;
} 