using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using proyectoU.Utilities;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace proyectoU
{
    public class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        float theta = 0f;
        Escenario esc = new Escenario(10,0,3);
        Escenario esc1 = new Escenario(-30, 0, 3);
        Ejes ejes = new Ejes();

        Stopwatch stopwatch = new Stopwatch();
        const float maxFps = 30;
        const float animationDuration = 5;
        const float animationDurationMilliseconds = 5000;
        //float startAngle = 0f;
        const float totalRotation = 720;
        const float step = totalRotation / (maxFps * animationDuration);

        const float deltaTime = 1000 / maxFps;
        float currentTimeLimit = deltaTime;

        float c = 0;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            esc.AddObjeto("U", U.getObjeto(esc));
            esc1.AddObjeto("U", U.getObjeto(esc1));
            //Serializer.save(esc, "escenario1.json");
            //esc = Serializer.Load<Escenario>("escenario1.json");
            stopwatch.Start();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();

            GL.Translate(0.0f, 0.0f, -50.0f);
            //GL.Rotate(-20.0f, 0.0, 1.0, 0.0);
            //GL.Rotate(-15.0f, 1.0, 0.0, 0.0);
            //GL.Rotate(theta, 0.0, 0.1, 0.0);

            
            ejes.Draw();
            esc.Draw();
            esc1.Draw();
            
            if (stopwatch.Elapsed.TotalMilliseconds < animationDurationMilliseconds)
            {
                float elapsedTime = (float)stopwatch.Elapsed.TotalMilliseconds;
                //Console.WriteLine(elapsedTime.ToString());
                //float progress = elapsedTime / animationDuration;
                if (elapsedTime > currentTimeLimit)
                {
                    Console.WriteLine(currentTimeLimit);

                    //esc.Rotate(step, 0, 1, 0);
                    esc.objetos["U"].Rotate(step, 0, 1, 0);
                    esc1.objetos["U"].Rotate(step, 0, 1, 0);
                    //esc.objetos["U"].partes["Derecha"].Rotate(step, 0, 1, 0);


                    c++;
                    Console.WriteLine(c);

                    currentTimeLimit += deltaTime;
                }
            }

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
            GL.Frustum(-1, 1, -1, 1, 1, 100);

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
