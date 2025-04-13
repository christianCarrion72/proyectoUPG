using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace proyectoU
{
    class Ejes
    {
        public Vertice centro;
        public Ejes()
        {
            centro = new Vertice(0, 0, 0);
        }
        public void Draw()
        {
            //Vertices
            GL.Color4(Color4.Green);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0f, 30f, 0f);
            GL.Vertex3(0f, -30f, 0f);
            GL.End();

            GL.Color4(Color4.Red);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(30f, 0f, 0f);
            GL.Vertex3(-30f, 0f, 0f);
            GL.End();

            GL.Color4(Color4.Yellow);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0f, 0f, -30f);
            GL.Vertex3(0f, 0f, 30f);
            GL.End();
        }

    }
}
