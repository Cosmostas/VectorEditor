using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEditor
{
    public interface IFigure
    {
        List<Point> getNode();
        void SetPoint(Point firstLocation, Point lastLocation);
    }
}
