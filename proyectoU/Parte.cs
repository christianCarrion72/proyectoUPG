using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;

namespace proyectoU
{
    public class Parte
    {

        public Vertice centro = new Vertice(0, 0, 0);
        public List<Cara> caras = new List<Cara>();

        public Parte() { }

        public Parte(float x, float y, float z)
        {
            centro = new Vertice(x,y,z);
        }

        public void AddCara(Cara p)
        {
            foreach (Vertice v in p.vertices) {
                v.X += centro.X;
                v.Y += centro.Y;
                v.Z += centro.Z;
            }
            caras.Add(p);
        }

        public void Draw()
        {
            foreach (Cara p in caras)
            {
                p.Draw();
            }
        }

        private void Transform(Matrix4 m)
        {
            foreach (Cara p in caras)
            {
                foreach (Vertice v in p.vertices)
                {
                    v.setValues(Vector4.Transform(v.ToVector4(), m));
                }

            }
        }

        public void Translate(float x, float y, float z)
        {
            Transform(Matrix4.CreateTranslation(x,y,z));
        }

        public void Scale(float x, float y, float z)
        {
            Transform(Matrix4.CreateScale(x, y, z));
        }
      
        public void Rotate(float angle, float x, float y, float z)
        {
            angle = MathHelper.DegreesToRadians(angle);

            Matrix4 toOrigin = Matrix4.CreateTranslation(-centro.X, -centro.Y, -centro.Z);
            Matrix4 r = Matrix4.CreateRotationX(angle * x);
            r = Matrix4.Mult(r, Matrix4.CreateRotationY(angle * y));
            r = Matrix4.Mult(r, Matrix4.CreateRotationZ(angle * z));
            Matrix4 toOriginal = Matrix4.CreateTranslation(centro.X, centro.Y, centro.Z);

            Matrix4 t = Matrix4.Mult(toOriginal, r);
            t = Matrix4.Mult(t, toOrigin);

            Transform(t);
        }
    }
}
