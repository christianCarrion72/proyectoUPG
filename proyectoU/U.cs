using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;

namespace proyectoU
{
    public class U
    {
        public Vertice centro;
        public U(float x,float y, float z) {
            centro = new Vertice(x,y,z);
        }

        public static Objeto getObjeto()
        {
            Objeto obj= new Objeto();

            Parte izquierda = new Parte(0, 0, 0);

            Cara p1 = new Cara(Color4.Green);
            p1.AddVertice(-3, 24, -3);
            p1.AddVertice(3, 24, -3);
            p1.AddVertice(3, 24, 3);
            p1.AddVertice(-3, 24, 3);
            izquierda.AddCara(p1);

            Cara p2 = new Cara(Color4.Green);
            p2.AddVertice(-3, 0, -3);
            p2.AddVertice(3, 0, -3);
            p2.AddVertice(3, 0, 3);
            p2.AddVertice(-3, 0, 3);
            izquierda.AddCara(p2);

            Cara p3 = new Cara(Color4.Green);
            p3.AddVertice(3, 24, 3);
            p3.AddVertice(3, 0, 3);
            p3.AddVertice(-3, 0, 3);
            p3.AddVertice(-3, 24, 3);
            izquierda.AddCara(p3);

            Cara p4 = new Cara(Color4.Green);
            p4.AddVertice(-3, 0, 3);
            p4.AddVertice(-3, 0, -3);
            p4.AddVertice(-3, 24, -3);
            p4.AddVertice(-3, 24, 3);
            izquierda.AddCara(p4);

            Cara p5 = new Cara(Color4.Green);
            p5.AddVertice(3, 0, -3);
            p5.AddVertice(3, 0, 3);
            p5.AddVertice(3, 24, 3);
            p5.AddVertice(3, 24, -3);
            izquierda.AddCara(p5);

            Cara p6 = new Cara(Color4.Green);
            p6.AddVertice(3, 24, -3);
            p6.AddVertice(3, 0, -3);
            p6.AddVertice(-3, 0, -3);
            p6.AddVertice(-3, 24, -3);
            izquierda.AddCara(p6);

            obj.AddParte("Izquierda", izquierda);


            Parte inferior = new Parte(0, 0, 0);

            Cara p7 = new Cara(Color4.Yellow);
            p7.AddVertice(3, 8, 3);
            p7.AddVertice(18, 8, 3);
            p7.AddVertice(18, 0, 3);
            p7.AddVertice(3, 0, 3);
            inferior.AddCara(p7);

            Cara p8 = new Cara(Color4.Yellow);
            p8.AddVertice(3, 8, 3);
            p8.AddVertice(3, 8, -3);
            p8.AddVertice(18, 8, -3);
            p8.AddVertice(18, 8, 3);
            inferior.AddCara(p8);

            Cara p9 = new Cara(Color4.Yellow);
            p9.AddVertice(3, 0, 3);
            p9.AddVertice(3, 0, -3);
            p9.AddVertice(18, 0, -3);
            p9.AddVertice(18, 0, 3);
            inferior.AddCara(p9);

            Cara p10 = new Cara(Color4.Yellow);
            p10.AddVertice(18, 8, 3);
            p10.AddVertice(18, 8, -3);
            p10.AddVertice(18, 0, -3);
            p10.AddVertice(18, 0, 3);
            inferior.AddCara(p10);

            Cara p11 = new Cara(Color4.Yellow);
            p11.AddVertice(3, 8, 3);
            p11.AddVertice(3, 8, -3);
            p11.AddVertice(3, 0, -3);
            p11.AddVertice(3, 0, 3);
            inferior.AddCara(p11);

            Cara p12 = new Cara(Color4.Yellow);
            p12.AddVertice(3, 8, -3);
            p12.AddVertice(18, 8, -3);
            p12.AddVertice(18, 0, -3);
            p12.AddVertice(3, 0, -3);
            inferior.AddCara(p12);

            obj.AddParte("Base", inferior);

            Parte derecha = new Parte(0, 0, 0);

            Cara p13 = new Cara(Color4.Green);
            p13.AddVertice(18, 24, -3);
            p13.AddVertice(24, 24, -3);
            p13.AddVertice(24, 24, 3);
            p13.AddVertice(18, 24, 3);
            derecha.AddCara(p13);

            Cara p14 = new Cara(Color4.Green);
            p14.AddVertice(18, 0, -3);
            p14.AddVertice(24, 0, -3);
            p14.AddVertice(24, 0, 3);
            p14.AddVertice(18, 0, 3);
            derecha.AddCara(p14);

            Cara p15 = new Cara(Color4.Green);
            p15.AddVertice(24, 24, 3);
            p15.AddVertice(24, 0, 3);
            p15.AddVertice(18, 0, 3);
            p15.AddVertice(18, 24, 3);
            derecha.AddCara(p15);

            Cara p16 = new Cara(Color4.Green);
            p16.AddVertice(18, 0, 3);
            p16.AddVertice(18, 0, -3);
            p16.AddVertice(18, 24, -3);
            p16.AddVertice(18, 24, 3);
            derecha.AddCara(p16);

            Cara p17 = new Cara(Color4.Green);
            p17.AddVertice(24, 0, -3);
            p17.AddVertice(24, 0, 3);
            p17.AddVertice(24, 24, 3);
            p17.AddVertice(24, 24, -3);
            derecha.AddCara(p17);

            Cara p18 = new Cara(Color4.Green);
            p18.AddVertice(24, 24, -3);
            p18.AddVertice(24, 0, -3);
            p18.AddVertice(18, 0, -3);
            p18.AddVertice(18, 24, -3);
            derecha.AddCara(p18);

            obj.AddParte("Derecha", derecha);

            return obj;
        }
    }
}
