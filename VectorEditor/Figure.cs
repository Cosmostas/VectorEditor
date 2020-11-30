using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    public interface Figure
    {
        List<Point> GetPoints();
        void SetPoints(Point firstPoint, Point lastPoint);
    }
}
