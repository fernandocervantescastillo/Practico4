using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practico4
{
    public abstract class IObjeto
    {
        public abstract void draw(Matrix4 matriz);
        public abstract void dispose();

    }
}
