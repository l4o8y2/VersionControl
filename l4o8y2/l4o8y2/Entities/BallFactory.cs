﻿
using l4o8y2.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4o8y2.Entities
{
   public class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
        public Color BallColor { get; set; }

        public Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
