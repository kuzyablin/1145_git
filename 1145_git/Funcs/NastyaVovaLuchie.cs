﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145_git.Funcs
{
    public class NastyaVovaLuchie : IDraw
    {
        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap("Nastenka.jpg");
            graphics.DrawImage(bitmap, new Point(0, 200));
        }
    }
}
