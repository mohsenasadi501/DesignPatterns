namespace DesignPatterns.Structural.Flyweight
{
    internal class PointService
    {
        private readonly PointIconFactory _pointIconFactory;

        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }
        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point
            {
                X = 1,
                Y = 2,
                Icon = _pointIconFactory.GetPointIcon(Enums.PointType.Cafe)
            };
            points.Add(point);
            return points;
        }
    }
}
