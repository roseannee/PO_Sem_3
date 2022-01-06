using System.Drawing;

namespace lab7
{
    internal class Ball
    {
        public Brush brush;
        public PointF position;
        public float size;

        public Ball(Brush brush, PointF position, float size)
        {
            this.brush = brush;
            this.position = position;
            this.size = size;
        }
    }
}
