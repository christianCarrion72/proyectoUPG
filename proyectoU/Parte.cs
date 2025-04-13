using System;
using System.Collections.Generic;
using System.Text;

namespace proyectoU
{
    public class Parte
    {

        public Vertice centro;
        public List<Cara> caras;

        public Parte()
        {
            centro = new Vertice(0,0,0);
        }

        public Parte(float x, float y, float z)
        {
            centro = new Vertice(x,y,z);
            caras = new List<Cara>();
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
      
    }
}
