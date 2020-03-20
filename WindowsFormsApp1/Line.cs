using System.Drawing;
using System;
using System.Windows.Forms;
namespace Shapes
{
    class Line : Shape {}
    [Serializable]
    class LineDraw : Draw
    {
        public override Shape DrawShape(ref Bitmap bmp)
        {
            Pen pen = new Pen(GetPenColor())
            {
                Width = PenWidth
            };
            pen.Width = PenWidth;
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawLine(pen, arr[0], arr[1], arr[2]+arr[0], arr[3]+arr[1]);
            return new Line();
        }
    }
}
