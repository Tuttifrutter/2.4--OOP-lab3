using System.Drawing;
using System;
using System.Windows.Forms;

namespace Shapes
{
    class Ellipse : Shape {}
    [Serializable]
    class EllipseDraw : Draw
    {
        public override Shape DrawShape(ref Bitmap bmp)
        {
            Pen pen = new Pen(GetPenColor())
            {
                Width = PenWidth
            };
            pen.Width = PenWidth;
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawEllipse(pen, arr[0], arr[1], arr[2], arr[3]);
            if (filling == true)
            {
                SolidBrush solidBrush = new SolidBrush(GetPenColor());
                graph.FillEllipse(solidBrush, arr[0], arr[1], arr[2], arr[3]);
            }
            return new Ellipse();
        }
    }
}
