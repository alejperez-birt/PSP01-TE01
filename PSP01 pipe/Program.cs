using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace pipe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la cadena que utilizaremos para mandar la información al servidor
            string datosArea = string.Empty;

            // Creamos el proceso mediante el método StartServer que nos devolvera el proceso
            Process proceso;
            StartServer(out proceso);
            Task.Delay(1000).Wait();

            // Definimos la variable de cliente con PipeName similar al que usaremos en el servidor y nos conectamos a él
            var cliente = new NamedPipeClientStream("CalculoAreasPipe");
            cliente.Connect();
            // Creamos reader y writer que nos servirán para escribir y leer del pipe
            StreamReader reader = new StreamReader(cliente);
            StreamWriter writer = new StreamWriter(cliente);

            // Mientras no nos salgamos del programa (opción -1) ejecutaremos este código para realizar diferentes cálculos
            while (true)
            {
                datosArea = string.Empty;
                // Llamamos al método RecogerDatos para generar el menú y obtener los datos que enviaremos al servidor
                // Se pasa como referencia el string datosArea
                RecogerDatos(ref datosArea);

                // Si se ha rellenado datosArea con los datos correctos...
                if(datosArea != null)
                {
                    if (datosArea.Equals("Exit")) // Evaluamos si hemos pulsado la opción -1
                    {
                        break; // Si es así nos salimos del bucle while
                    }

                    // Escribimos en el writer los datos recogidos por consola
                    // Los datos se enviarán al servidor con el siguiente formato:
                    // "rectangulo base altura 3 4", donde:
                    // 3 es el valor recogido correspondiente a la base (primer dato recogido)
                    // 4 es el valor recogido correspondiente a la altura (segundo dato recogido)
                    writer.WriteLine(datosArea);
                    // Limpiamos el writer
                    writer.Flush();

                    // Mostramos por pantalla el resultado del cálculo del área recibido del servidor
                    Console.WriteLine("");
                    Console.WriteLine(reader.ReadLine());
                }

            }

            // Paramos el proceso si no es nulo o no se ha salido
            if(proceso != null && !proceso.HasExited)
            {
                proceso.Kill();
                proceso = null;
            }
        }

        // Método que recibe como referencia el string vacío datosArea y lo rellena con los datos obtenidos por consola
        private static void RecogerDatos(ref string datosArea)
        {
            // Mostramos el menú de opciones 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*****  C Á L C U L O   D E   Á R E A S  *****");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
            Console.WriteLine("Área que desea calcular:");
            Console.WriteLine(" 1 - Círculo");
            Console.WriteLine(" 2 - Triángulo");
            Console.WriteLine(" 3 - Rectángulo");
            Console.WriteLine(" 4 - Pentágono");
            Console.WriteLine("(-1) Salir");
            Console.WriteLine("");
            Console.Write("Introduzca el área a calcular: ");

            // Leemos de la consola la opción introducida y la enviamos al método ValidarOpcion
            string areaConsola = Console.ReadLine();
            ValidarOpcion(areaConsola, ref datosArea);
        }

        // Método que recibe el texto de la opción recibido por consola y lo valida
        private static void ValidarOpcion(string areaConsola, ref string datosArea)
        {
            int opcion = int.MaxValue;

            // Si la opción introducida por consola no se puede convertir en un entero, mostramos un mensaje y asignamos
            // el valor null a datosArea para que no se realice ningún envío y os vuelva a mostrar el menú por consola
            if(!Int32.TryParse(areaConsola, out opcion))
            {
                Console.WriteLine("La opción introducida ({0}) no es una opción válida!!!", areaConsola);
                datosArea = null;
            }
            else // Si el valor es un entero lo evaluamos
            {
                switch (opcion){
                    case 1: 
                        // Se trata del area de un círculo
                        // Comenzamos a rellenar datosArea con el area y los datos que se solicitarán
                        datosArea = "círculo Radio vacio";
                        // Llamamos al método IntroducirDatos para solicitarlos
                        IntroducirDatos(ref datosArea);
                        break;

                    case 2:
                        datosArea = "triángulo Base Altura";
                        IntroducirDatos(ref datosArea);
                        break;

                    case 3:
                        datosArea = "rectángulo Base Altura";
                        IntroducirDatos(ref datosArea);
                        break;

                    case 4:
                        datosArea = "pentágono Lado Apótema";
                        IntroducirDatos(ref datosArea);
                        break;

                    case -1: // Rellenamos datosArea con Exit para detectar que queremos abandonar el programa
                        datosArea = "Exit";
                        break;

                    default: // Esta opción se activará cuando no se haya metido un entero válido
                        // Lo mostramos por pantalla y asignando null a datosArea forzamos a mostrar de nuevo el menú
                        Console.WriteLine("La opción introducida ({0}) no es una opción válida!!!", opcion);
                        datosArea = null;
                        break;
                }
            }
        }

        // Método que recibe como referencia datosArea y lo termina de rellenar con los datos necesarios
        private static void IntroducirDatos(ref string datosArea)
        {
            // Convertimos datosArea a un array para movernos mejor entre los datos
            string[] misDatos = datosArea.Split(" ");
            string datoConsola = string.Empty;

            // Recorremos los datos del array a partir del segundo elemento para saber que datos (base, altura, radio, lado...)
            // tenemos que pedir por consola
            for(int i = 1; i<misDatos.Length; i++)
            {
                // Si el dato a pedir es "vacio" se trata del circulo que unicamente necesita un dato
                if (!misDatos[i].Equals("vacio"))
                {
                    while (true)
                    {
                        // Solicitamos los datos por consola
                        Console.Write("{0} del {1} (en cms): ", misDatos[i], misDatos[0]);
                        datoConsola = Console.ReadLine();
                        
                        // Si el dato introducido se puede convertir a float lo añadimos a datosArea y salimos del bucle while
                        if(Single.TryParse(datoConsola, out float miDato))
                        {
                            datosArea += " " + datoConsola;
                            break;
                        }
                        else // Si no es un número mostramos el error por consola y se sigue solicitando el dato
                        {
                            Console.WriteLine("El dato introducido no es un número. Vuelva a intentarlo...");
                            Console.WriteLine("");
                        }
                    }
                } else
                {
                    datosArea += " " + 0;
                }
            }
        }

        static Process StartServer(out Process proceso01)
        {
            // Creamos el objeto y la pasamos como argumento el ejecutable pipesServidor con el que se creará el proceso.
            ProcessStartInfo info = new ProcessStartInfo(@"..\..\Release\net6.0\win-x64\pipesServidor.exe");

            // Creamos una ventana nueva
            info.CreateNoWindow=false;

            // Creamos la ventana de tipo normal
            info.WindowStyle = ProcessWindowStyle.Normal;

            // La ventana se ejecutará cuando iniciemos el proceso.
            info.UseShellExecute = true;

            // Arrancamos el proceso y guarda sus datos en la variable proceso01
            proceso01 = Process.Start(info);

            return proceso01;
        }
    }
}
