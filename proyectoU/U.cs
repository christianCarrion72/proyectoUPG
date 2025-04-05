using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;

namespace proyectoU
{
    public static class U
    {
        /*public static List<List<Vertice>> Poligonos = new List<List<Vertice>>
        {
            //Primer Bloque
            //Izquierda
            new List<Vertice> {
                new Vertice(-3f, 24f, -3f),
                new Vertice( 3f, 24f, -3f),
                new Vertice( 3f, 24f,  3f),
                new Vertice(-3f, 24f,  3f),
            },
            new List<Vertice> {
                new Vertice(-3f, 0f, -3f),
                new Vertice( 3f, 0f, -3f),
                new Vertice( 3f, 0f,  3f),
                new Vertice(-3f, 0f,  3f),
            },
            new List<Vertice> {
                new Vertice( 3f, 24f,  3f),
                new Vertice( 3f, 0f,   3f),
                new Vertice(-3f, 0f,   3f),
                new Vertice(-3f, 24f,  3f),
            },
            new List<Vertice> {
                new Vertice(-3f, 0f,   3f),
                new Vertice(-3f, 0f,  -3f),
                new Vertice(-3f, 24f, -3f),
                new Vertice(-3f, 24f,  3f),
            },
            new List<Vertice> {
                new Vertice(3f, 0f, -3f),
                new Vertice(3f, 0f,  3f),
                new Vertice(3f, 24f,  3f),
                new Vertice(3f, 24f, -3f),
            },
            new List<Vertice> {
                new Vertice(3f, 24f, -3f),
                new Vertice(3f, 0f,  -3f),
                new Vertice(-3f, 0f, -3f),
                new Vertice(-3f, 24f, 3f),
            },
            //Segundo bloque
            //Base  
            new List<Vertice> {
                new Vertice( 3f, 8f,  3f),
                new Vertice( 18f, 8f,  3f),
                new Vertice( 18f, 0f,  3f),
                new Vertice( 3f, 0f,  3f),
            },
            new List<Vertice> {
                new Vertice( 3f, 8f, 3f),
                new Vertice( 3f, 8f, -3f),
                new Vertice( 18f, 8f,  -3f),
                new Vertice( 18f, 8f,  3f),
            },
            new List<Vertice> {
                new Vertice( 3f, 0f,  3f),
                new Vertice( 3f, 0f,   -3f),
                new Vertice( 18f, 0f,   -3f),
                new Vertice( 18f, 0f,  3f),
            },
            new List<Vertice> {
                new Vertice(18f, 8f, 3f),
                new Vertice(18f, 8f, -3f),
                new Vertice(18f, 0f, -3f),
                new Vertice(18f, 0f, 3f),
            },
            new List<Vertice> {
                new Vertice(3f, 8f, 3f),
                new Vertice(3f, 8f, -3f),
                new Vertice(3f, 0f, -3f),
                new Vertice(3f, 0f, 3f),
            },
            new List<Vertice> {
                new Vertice(3f, 8f, -3f),
                new Vertice(18f, 8f, -3f),
                new Vertice(18f, 0f, -3f),
                new Vertice(3f, 0f, -3f),
            },
            //Tercer bloque
            //Derecha
            new List<Vertice> {
                new Vertice( 18f, 24f, -3f),
                new Vertice( 24f, 24f, -3f),
                new Vertice( 24f, 24f,  3f),
                new Vertice( 18f, 24f,  3f),
            },
            new List<Vertice> {
                new Vertice( 18f, 0f, -3f),
                new Vertice( 24f, 0f, -3f),
                new Vertice( 24f, 0f, 3f),
                new Vertice( 18f, 0f, 3f),
            },
            new List<Vertice> {
                new Vertice( 24f, 24f, 3f),
                new Vertice( 24f, 0f,  3f),
                new Vertice( 18f, 0f,  3f),
                new Vertice( 18f, 24f, 3f),
            },
            new List<Vertice> {
                new Vertice(18f, 0f, 3f),
                new Vertice(18f, 0f, -3f),
                new Vertice(18f, 24f, -3f),
                new Vertice(18f, 24f, 3f),
            },
            new List<Vertice> {
                new Vertice(24f, 0f, -3f),
                new Vertice(24f, 0f, 3f),
                new Vertice(24f, 24f, 3f),
                new Vertice(24f, 24f, -3f),
            },
            new List<Vertice> {
                new Vertice(24f, 24f, -3f),
                new Vertice(24f, 0f, -3f),
                new Vertice(18f, 0f, -3f),
                new Vertice(18f, 24f, -3f),
            },
        };

        public static List<List<Vertice>> Contornos = new List<List<Vertice>>
        {
            // Contorno base
            new List<Vertice> {
                new Vertice(-3f, 0f, -3f),
                new Vertice(24f, 0f, -3f),
                new Vertice(24f, 0f, 3f),
                new Vertice(-3f, 0f, 3f),
            },
            // Contorno cara frontal
            new List<Vertice> {
                new Vertice(-3f, 0f, 3f),
                new Vertice(-3f, 24f, 3f),
                new Vertice(3f, 24f, 3f),
                new Vertice(3f, 8f, 3f),
                new Vertice(18f, 8f, 3f),
                new Vertice(18f, 24f, 3f),
                new Vertice(24f, 24f, 3f),
                new Vertice(24f, 0f, 3f),
            },
            // Contorno cara trasera
            new List<Vertice> {
                new Vertice(-3f, 0f, -3f),
                new Vertice(-3f, 24f, -3f),
                new Vertice(3f, 24f, -3f),
                new Vertice(3f, 8f, -3f),
                new Vertice(18f, 8f, -3f),
                new Vertice(18f, 24f, -3f),
                new Vertice(24f, 24f, -3f),
                new Vertice(24f, 0f, -3f),
            },
            // Tapa superior central
            new List<Vertice> {
                new Vertice(-3f, 24f, -3f),
                new Vertice(3f, 24f, -3f),
                new Vertice(3f, 24f, 3f),
                new Vertice(-3f, 24f, 3f),
            },
            // Tapa superior derecha
            new List<Vertice> {
                new Vertice(18f, 24f, -3f),
                new Vertice(24f, 24f, -3f),
                new Vertice(24f, 24f, 3f),
                new Vertice(18f, 24f, 3f),
            },
        };*/
    }

}
/*GL.Color4(Color4.Blue);

            foreach (List<Vertice> poligono in U.Poligonos)
            {
                GL.Begin(BeginMode.Polygon);
                foreach (Vertice v in poligono)
                {
                    float x = v.X + centro.X;
                    float y = v.Y + centro.Y;
                    float z = v.Z + centro.Z;
                    GL.Vertex3(x, y, z);
                }
                GL.End();
            }

            // Dibujar contornos en negro
            GL.Color4(Color4.Black);
            foreach (List<Vertice> contorno in U.Contornos)
            {
                GL.Begin(BeginMode.LineLoop);
                foreach (Vertice v in contorno)
                {
                    GL.Vertex3(v.X + centro.X, v.Y + centro.Y, v.Z + centro.Z);
                }
                GL.End();
            }*/