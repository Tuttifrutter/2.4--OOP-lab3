using System.Drawing;
using System;
using System.Windows.Forms;

namespace Shapes
{
    class Quadrate : Shape { }
    [Serializable]
    class QuadrateDraw : Draw
    {
        public override Shape DrawShape(ref Bitmap bmp)
        {
            Pen pen = new Pen(GetPenColor())
            {
                Width = PenWidth
            };
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawRectangle(pen, arr[0], arr[1], (arr[2] + arr[3]) / 2, (arr[2] + arr[3]) / 2);
            if (filling == true)
            {
                SolidBrush solidBrush = new SolidBrush(GetPenColor());
                graph.FillRectangle(solidBrush, arr[0], arr[1], (arr[2] + arr[3]) / 2, (arr[2] + arr[3]) / 2);
            }
            return new Quadrate();
        }
    }

}
