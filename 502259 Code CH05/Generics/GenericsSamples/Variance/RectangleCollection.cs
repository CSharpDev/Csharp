﻿using System;

namespace Wrox.ProCSharp.Generics
{
    //自定义实体的集合
    public class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data = new Rectangle[3]
        {
            new Rectangle { Height=2, Width=5},
            new Rectangle { Height=3, Width=7},
            new Rectangle { Height=4.5, Width=2.9}
        };

        public static RectangleCollection GetRectangles()
        {
            return new RectangleCollection();
        }

        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index > data.Length)
                    throw new ArgumentOutOfRangeException("index");
                return data[index];
            }
        }
        public int Count
        {
            get
            {
                return data.Length;
            }
        }
    }
}
