using static DesignPatterns.Structural.Flyweight.Model.Enums;
namespace DesignPatterns.Structural.Flyweight
{
    internal class PointIcon
    {
        public PointType Type { get; set; }
        public byte[] Icon { get; set; }
    }
}
