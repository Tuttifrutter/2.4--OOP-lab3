using System.Drawing;
using System;
using System.Windows.Forms;


namespace Shapes
{
    class Triangle : Shape { }
    [Serializable]
    class TriangleDraw : Draw
    {
        public override Shape DrawShape(ref Bitmap bmp)
        {
            Pen pen = new Pen(GetPenColor())
            {
                Width = PenWidth
            };
            Graphics graph = Graphics.FromImage(bmp);
            double x3, y3;
            if (arr[0] + arr[2] > arr[1] + arr[3])
            {
                x3 = arr[0] + arr[2] / 2;
                y3 = arr[1] - (arr[0] + arr[2]) * Math.Sqrt(3) / 6;
            }
            else
            {
                y3 = arr[1] + arr[3] / 2;
                x3 = arr[0] - (arr[1] + arr[3]) * Math.Sqrt(3) / 6;
            }
            Point[] PointARR = { new Point(arr[0], arr[1]), new Point(arr[2] + arr[0], arr[3] + arr[1]), new Point((int)x3,(int)y3)};
            graph.DrawPolygon(pen, PointARR);
            if (filling == true) 
            {
                SolidBrush solidBrush = new SolidBrush(GetPenColor());
                graph.FillPolygon(solidBrush, PointARR);
            }
            return new Triangle();
        }
    }
}
