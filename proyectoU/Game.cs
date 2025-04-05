﻿using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;


namespace proyectoU
{
    internal class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        float theta = 0f;
        Objeto obj1;
        Objeto obj2;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            obj1 = new Objeto(3, 0, 0,"U.txt");
            obj2 = new Objeto(-30, 0, 0, "U.txt");
            
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -50.0f);
            //GL.Rotate(-20.0f, 0.0, 1.0, 0.0);
            GL.Rotate(-15.0f, 1.0, 0.0, 0.0);
            GL.Rotate(theta, 0.0, 0.5, 0.0);

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

            obj1.Draw();
            obj2.Draw();

            theta += 1.0f;
            if (theta > 360) theta -= 360;

            Context.SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Frustum(-1.0f, 1.0f, -1.0f, 1.0f, 0.8f, 100.0f);

            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }
    }
}
