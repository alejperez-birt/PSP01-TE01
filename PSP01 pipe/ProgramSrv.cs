using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace pipesServidor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Definimos la variable de servidor con PipeName similar al que hemos usado en el cliente
                // y esperamos a que éste se conecte
                var server = new NamedPipeServerStream("CalculoAreasPipe");
                server.WaitForConnection();
                Console.WriteLine("Conexión a servidor establecida.");
                Console.WriteLine("Pipe Servidor esperando datos...");

                // Creamos reader y writer que nos servirán para escribir y leer del pipe
                StreamReader reader = new StreamReader(server);
                StreamWriter writer = new StreamWriter(server);
                
                // Con este bucle while conseguimos que el servidor esté siempre esperando recibir datos del cliente
                while (true)
                {
                    // Leemos los datos recibidos del cliente a través del reader
                    var linea = reader.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Pipe Servidor datos recibidos...");

                    // Convertimos los datos recibidos en un array para manejarlos de forma independiente
                    string[] datosCalculo = linea.Split(" ");
                    // Mostramos la informaciónpor consola
                    Console.WriteLine("Pipe Servidor procesando datos: '{0}'", linea);
                    string areaCalcular = "Pipe Servidor cálculo del área: " +
                        datosCalculo[0] + " de " + datosCalculo[1] + " " + datosCalculo[3] + "cm.";
                    if (!datosCalculo[2].Equals("vacio"))
                    {
                        areaCalcular += " y " + datosCalculo[2] + " " + datosCalculo[4] + "cm.";
                    }
                    Console.WriteLine(areaCalcular);

                    // Llamamos a ProcesarDatos enviando el array datosCalculo para calcular el área correspondiente
                    // Este método nos devolverá un string con el resultado de la siguiente manera:
                    // "El área del triángulo es 23,21cm2."
                    string resultado = ProcesarDatos(datosCalculo);
                    // Escribimos el resultado en el writer y lo mostramos por consola
                    writer.WriteLine(String.Join("", resultado));
                    Console.WriteLine(String.Join("","Pipe Servidor datos enviados: ", resultado));
                    // Limpiamos el writer
                    writer.Flush();
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}. Apangado servidor por error", e.Message);
            }
                
           
        }

        private static string ProcesarDatos(string[] datosCalculo)
        {
            // Iniciamos las variables que necesitaremos
            // En el caso de primerDato y segundoDato lo haremos directamente con los datos recibidos en el array
            float area = 0;
            float primerDato = Single.Parse(datosCalculo[3]);
            float segundoDato = Single.Parse(datosCalculo[4]);

            // Analizamos el primer valor del array que corresponde al tipo de area
            // y realizamos el calculo dejando el resultado en la variable area
            switch (datosCalculo[0])
            {
                case "círculo":
                    area = Convert.ToSingle(Math.PI) * primerDato * primerDato;
                    break;

                case "triángulo":
                    area = primerDato * segundoDato / 2;
                    break;

                case "rectángulo":
                    area = primerDato * segundoDato;
                    break;

                case "pentágono":
                    area = primerDato * 5 * segundoDato / 2;
                    break;
            }
            // Generamos el string con el resultado completo y lo devolvemos
            string rdo = "El área del " + datosCalculo[0] + " es " + area + "cm2.";
            return rdo;
        }
    }
}
