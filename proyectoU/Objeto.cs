using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace proyectoU
{
    class Objeto
    {
        public Vertice centro;
        private List<List<Vertice>> poligonos;

        public Objeto(float x, float y, float z,string rutaArchivo)
        {
            centro = new Vertice(x, y, z);
            poligonos = CargadorDeVertices.CargarVertices(rutaArchivo);
        }

        public void Draw()
        {
            GL.Color4(Color4.Blue);
            foreach (List<Vertice> poligono in poligonos)
            {
                GL.Begin(BeginMode.Polygon);
                foreach (Vertice v in poligono)
                    GL.Vertex3(v.X + centro.X, v.Y + centro.Y, v.Z + centro.Z);
                GL.End();
            }
            
        }
    }
}

