using System.Drawing;

namespace lw1.Shape
{
    public class CEmblem
    {
        private int a;
        private Graphics graphics;
        public int X { get; set; }
        public int Y { get; set; }

        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.a = 50;
        }
        
        public CEmblem(Graphics graphics, int X, int Y, int a)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.a = a;
        }
        
        private void Draw(Pen pen)
        {
            Rectangle circle = new Rectangle(X - 3 * a, Y - a, 2 * a, 2 * a);
            Rectangle rectangle = new Rectangle(X + a, Y - a, 2 * a, 2 * a);
            Point[] triangle =
            {
                new Point(X - a, Y),
                new Point(X + a, Y - a),
                new Point(X + a, Y + a)
            };
            
            graphics.DrawEllipse(pen, circle);
            graphics.DrawRectangle(pen, rectangle);
            graphics.DrawPolygon(pen, triangle);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }
        
        public void Expand()
        {
            Hide();
            a++;
            Show();
        }
        
        public void Expand(int dR)
        {
            Hide();
            a += dR;
            Show();
        }
        
        public void Collapse()
        {
            Hide();
            a--;
            Show();
        }
        
        public void Collapse(int dR)
        {
            Hide();
            a -= dR;
            Show();
        }
        
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}