using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.Text;

namespace proyectoU
{
    public class Cara
    {
        public Color4 color = Color4.Gray;
        public List<Vertice> vertices = new List<Vertice>();

        public Cara() { }

        public Cara(Color4 color)
        {
            this.color = color;
        }

        public void AddVertice(float x, float y, float z)
        {
            vertices.Add(new Vertice(x, y, z));
        }

        public void Draw()
        {
            GL.Color4(Color4.Orange);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vertice v in vertices)
            {
                GL.Vertex3(v.X, v.Y, v.Z);
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertice v in vertices)
            {
                GL.Vertex3(v.X, v.Y, v.Z);
            }
            GL.End();
        }
    }
}
