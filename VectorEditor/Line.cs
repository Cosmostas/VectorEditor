using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    public class Line : IFigure
    {
        public Point BeginLine;
        public Point EndLine;

        Line()
        {

        }
        Line(Point firstLocation, Point lastLocation)
        {
            BeginLine = firstLocation;
            EndLine = lastLocation;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>(2) { BeginLine, EndLine };
        }

        public void SetPoints(Point firstLocation, Point lastLocation)
        {
            BeginLine = firstLocation;
            EndLine = lastLocation;
    }
}
}
