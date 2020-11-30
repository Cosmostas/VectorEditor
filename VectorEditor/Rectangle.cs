using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    public class Rectangle : Figure
    {
        List<Line> listLines;
        public Rectangle()
        {
            listLines = new List<Line>(4) { 
                new Line(),
                new Line(),
                new Line(),
                new Line()
            };
        }
        public Rectangle(Point firstPoint, Point lastPoint)
        {
            listLines = new List<Line>(4) {
                new Line(firstPoint, new Point(firstPoint.X, lastPoint.Y)),
                new Line(new Point(firstPoint.X, lastPoint.Y), lastPoint),
                new Line(lastPoint, new Point(lastPoint.X, firstPoint.Y)),
                new Line(new Point(lastPoint.X, firstPoint.Y), firstPoint)
            };
        }

        public List<Point> GetPoints()
        {
            List <Point> dots = new List<Point>(4) {
                listLines[0]._beginLine,
                listLines[1]._beginLine,
                listLines[2]._beginLine,
                listLines[3]._beginLine
            };

            return dots;
        }

        public void SetPoints(Point firstPoint, Point lastPoint)
        {
            listLines = new List<Line>(4) {
                new Line(firstPoint, new Point(firstPoint.X, lastPoint.Y)),
                new Line(new Point(firstPoint.X, lastPoint.Y), lastPoint),
                new Line(lastPoint, new Point(lastPoint.X, firstPoint.Y)),
                new Line(new Point(lastPoint.X, firstPoint.Y), firstPoint)
            };
        }
    }
}
