﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Game.Objects
{
    class BaseObject
    {
        public float X;
        public float Y;
        public float Angle;

        public BaseObject(float x, float y, float angle)
        {
            X = x;
            Y = y;
            Angle = angle;
        }
        public Matrix GetTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(X,Y); // смещаем ее в пространстве
            matrix.Rotate(Angle);
            return matrix;
        }
        public virtual void Render(Graphics g)
        {
            // тут пусто
        }
    }
}