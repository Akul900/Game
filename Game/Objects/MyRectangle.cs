using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game.Objects
{
    class MyRectangle : BaseObject
    {
      
        public MyRectangle(float x, float y, float angle) : base(x, y, angle)
        {
        }

        // переопределяем Render
        public override void Render(Graphics g)
        {
            // и запихиваем туда код из формы
            g.FillEllipse(new SolidBrush(Color.Yellow), -15, -15, 30, 30);
            g.DrawEllipse(new Pen(Color.Red, 2), -15, -15, 30, 30);
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }
    }
}
