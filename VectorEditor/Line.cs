using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    public class Line : Figure
    {
        public Point _beginLine { get; private set; }
        public Point _endLine { get; private set; }
        public Line()
        {
            _beginLine = new Point(0, 0);
            _endLine = new Point(0, 0);
        }

        public Line(Point beginLine, Point endLine)
        {

            _beginLine = beginLine;
            _endLine = endLine;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>(2) { _beginLine, _endLine };
        }

        public void SetPoints(Point beginLine, Point endLine)
        {
            _beginLine = beginLine;
            _endLine = endLine;
        }
    };
}
