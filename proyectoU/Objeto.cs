using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace proyectoU
{
    public class Objeto
    {
        public Vertice centro;
        public Dictionary<String, Parte> partes;

        public Objeto()
        {
            centro = new Vertice(0,0,0);
            partes = new Dictionary<string, Parte>();
        }

        public Objeto(float x, float y, float z)
        {
            centro = new Vertice(x,y,z);
            partes = new Dictionary<String, Parte>();
        }

        public void AddParte(string name, Parte p)
        {
            p.centro.X += centro.X;
            p.centro.Y += centro.Y;
            p.centro.Z += centro.Z;

            partes.Add(name, p);
        }

        public void Draw()
        {
            foreach (Parte p in partes.Values)
            {
                p.Draw();
            }
        }
    }
}

