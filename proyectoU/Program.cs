using System;
using System.Collections.Generic;
using System.Text;

namespace proyectoU
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "OpenTK - Hola Mundo 'Estructura Básica'"))
            {
                game.Run(60.0);
            }
        }
    }
}