using static DesignPatterns.Structural.Flyweight.Enums;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight Factory
    /// </summary>
    internal class PointIconFactory
    {
        Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                var icon = new PointIcon();
                icon.Type = pointType;
                icon.Icon = null;
                icons.Add(pointType, icon);
            }
            return icons[pointType];
        }
    }
}
