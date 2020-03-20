using System.Drawing;
using System;
namespace Shapes
{
    public abstract class Shape { }
    [Serializable]
    public abstract class Draw
    {
        public abstract Shape DrawShape(ref Bitmap bmp);
        public int PenWidth;
        public string PenColor;
        public int[] arr;
        public bool filling;
        public Color GetPenColor()
        {
            try
            {
                return Color.FromArgb(Convert.ToInt32(PenColor, 16));
            }
            catch (FormatException)
            {
                return Color.FromName(PenColor);
            }
            catch
            {
                return Color.FromArgb(Convert.ToInt32(PenColor, 16));
            }
        }
    }
}

