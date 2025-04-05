using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace proyectoU
{
    public static class CargadorDeVertices
    {
        public static List<List<Vertice>> CargarVertices(string rutaArchivo)
        {
            List<List<Vertice>> poligonos = new List<List<Vertice>>();
            try
            {
                var lineas = File.ReadAllLines(rutaArchivo);
                List<Vertice> poligonoActual = new List<Vertice>();

                foreach (var linea in lineas)
                {
                    if (linea == null || linea.Trim().Length == 0) continue;

                    try
                    {
                        string[] partes = linea.Split(',');
                        if (partes.Length != 3)
                        {
                            Console.WriteLine($"Línea ignorada (no tiene 3 partes): '{linea}'");
                            continue;
                        }

                        float x = float.Parse(partes[0].Trim(), CultureInfo.InvariantCulture);
                        float y = float.Parse(partes[1].Trim(), CultureInfo.InvariantCulture);
                        float z = float.Parse(partes[2].Trim(), CultureInfo.InvariantCulture);

                        Vertice vertice = new Vertice(x, y, z);
                        poligonoActual.Add(vertice);

                        if (poligonoActual.Count == 4)
                        {
                            poligonos.Add(new List<Vertice>(poligonoActual));
                            poligonoActual.Clear();
                        }
                    }
                    catch (Exception exLinea)
                    {
                        Console.WriteLine($"❌ Error en línea: '{linea}' → {exLinea.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return poligonos;
        }
    }
}


