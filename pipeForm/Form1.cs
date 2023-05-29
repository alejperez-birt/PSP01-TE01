using System.Diagnostics;
using System.IO.Pipes;

namespace pipeForm
{
    public partial class Form1 : Form
    {
        // Variables necesarias
        Process proceso;
        StreamReader reader;
        StreamWriter writer;

        string datosArea = string.Empty;
        bool datosCorrectos = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Lanzar_Click(object sender, EventArgs e)
        {
            // Si el proceso no está lanzado lo hacemos de la misma manera que hemos hecho en la aplicación de consola
            if(proceso == null)
            {
                StartServer(out proceso);
                NamedPipeClientStream cliente = new NamedPipeClientStream("CalculoAreasPipe");
                cliente.Connect();
                reader = new StreamReader(cliente);
                writer = new StreamWriter(cliente);

                // Mostramos el texto con el Id del proceso en la etiqueta
                lbl_EstadoProceso.Text = "Proceso Cálculo Arrancado ID: " + proceso.Id;
                
                // Activamos los checkbox y el boton de finalizar proceso y desactivamos el botón de lanzar proceso
                btn_FinalizarProceso.Enabled = true;
                btn_Lanzar.Enabled = false;

                chkB_Circulo.Enabled = true;
                chkB_Triangulo.Enabled = true;
                chkB_Rectangulo.Enabled = true;
                chkB_Pentagono.Enabled = true;
            }

        }

        private void chkB_Circulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Circulo.Checked)
            {
                // Si el checkbox se ha marcado llamamos al método DatosDisabled que inicializa
                // los estados de algunos elementos del formulario a como deben aparecer
                DatosDisabled();

                // Desmarcamos el resto de checkbox y activamos las etiquetas y textbox que corresponden a ese area
                // También activamos el botón calcular y la etiqueta de resultado
                chkB_Triangulo.Checked = false;
                chkB_Rectangulo.Checked = false;
                chkB_Pentagono.Checked = false;

                lbl_RadioCirculo.Enabled = true;
                txtB_RadioCirculo.Enabled = true;

                btn_Calcular.Enabled = true;
                lbl_Resultado.Enabled = true;

            } else // Si el checkbox se ha desmarcado desactivamos algunos elementos del formulario
                   // y el botón calcular y la etiqueta resultado 
            {
                DatosDisabled();
                btn_Calcular.Enabled = false;
                lbl_Resultado.Enabled = false;
            }
        }

        // Método similar al del circulo
        private void chkB_Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Triangulo.Checked)
            {
                DatosDisabled();

                chkB_Circulo.Checked = false;
                chkB_Rectangulo.Checked = false;
                chkB_Pentagono.Checked = false;

                lbl_BaseTriangulo.Enabled = true;
                txtB_BaseTriangulo.Enabled = true;
                lbl_AlturaTriangulo.Enabled = true;
                txtB_AlturaTriangulo.Enabled = true;

                btn_Calcular.Enabled = true;
                lbl_Resultado.Enabled = true;

            }
            else
            {
                DatosDisabled();
                btn_Calcular.Enabled = false;
                lbl_Resultado.Enabled = false;
            }
        }

        // Método similar al del circulo
        private void chkB_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Rectangulo.Checked)
            {
                DatosDisabled();

                chkB_Circulo.Checked = false;
                chkB_Triangulo.Checked = false;
                chkB_Pentagono.Checked = false;

                lbl_BaseRectangulo.Enabled = true;
                txtB_BaseRectangulo.Enabled = true;
                lbl_AlturaRectangulo.Enabled = true;
                txtB_AlturaRectangulo.Enabled = true;

                btn_Calcular.Enabled = true;
                lbl_Resultado.Enabled = true;

            }
            else
            {
                DatosDisabled();
                btn_Calcular.Enabled = false;
                lbl_Resultado.Enabled = false;
            }
        }

        // Método similar al del circulo
        private void chkB_Pentagono_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Pentagono.Checked)
            {
                DatosDisabled();

                chkB_Circulo.Checked = false;
                chkB_Triangulo.Checked = false;
                chkB_Rectangulo.Checked = false;

                lbl_LadoPentagono.Enabled = true;
                txtB_LadoPentagono.Enabled = true;
                lbl_ApotemaPentagono.Enabled = true;
                txtB_ApotemaPentagono.Enabled = true;

                btn_Calcular.Enabled = true;
                lbl_Resultado.Enabled = true;

            }
            else
            {
                DatosDisabled();
                btn_Calcular.Enabled = false;
                lbl_Resultado.Enabled = false;
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Evaluamos que checkbox es el que esta activo
            if (chkB_Circulo.Checked)
            {
                // Comenzamos a rellenar datosArea
                datosArea = "círculo Radio vacio";
                // Si se ha introducido un valor en el textbox y éste es un número válido seguimos completando datosArea
                if (txtB_RadioCirculo.Text != "" && Single.TryParse(txtB_RadioCirculo.Text, out float operando01))
                {
                    datosArea += " " + txtB_RadioCirculo.Text + " " + 0;
                    lbl_Mensaje.Text = "";
                    // Ponemos a true la variable que nos indica que los datos son correctos
                    // y podemos enviar los datos al servidor
                    datosCorrectos = true;
                } else // Mostramos un mensaje de error en una etiqueta creada para ello
                       // y devolvemos el foco al textbox que ha generado el error
                {
                    lbl_Mensaje.Text = "Introduzca un radio válido";
                    txtB_RadioCirculo.Focus();
                }
            } 
            else if (chkB_Triangulo.Checked)
            {
                datosArea = "triángulo Base Altura"; ;
                if (txtB_BaseTriangulo.Text != "" && Single.TryParse(txtB_BaseTriangulo.Text, out float operando01))
                {
                    datosArea += " " + txtB_BaseTriangulo.Text;
                    lbl_Mensaje.Text = "";
                    if (txtB_AlturaTriangulo.Text != "" && Single.TryParse(txtB_AlturaTriangulo.Text, out float operando02))
                    {
                        datosArea += " " + txtB_AlturaTriangulo.Text;
                        lbl_Mensaje.Text = "";
                        datosCorrectos = true;
                    }
                    else
                    {
                        lbl_Mensaje.Text = "Introduzca una altura válida";
                        txtB_AlturaTriangulo.Focus();
                    }
                }
                else
                {
                    lbl_Mensaje.Text = "Introduzca una base válida";
                    txtB_BaseTriangulo.Focus();
                }
            }
            else if (chkB_Rectangulo.Checked)
            {
                datosArea = "rectángulo Base Altura"; ;
                if (txtB_BaseRectangulo.Text != "" && Single.TryParse(txtB_BaseRectangulo.Text, out float operando01))
                {
                    datosArea += " " + txtB_BaseRectangulo.Text;
                    lbl_Mensaje.Text = "";
                    if (txtB_AlturaRectangulo.Text != "" && Single.TryParse(txtB_AlturaRectangulo.Text, out float operando02))
                    {
                        datosArea += " " + txtB_AlturaRectangulo.Text;
                        lbl_Mensaje.Text = "";
                        datosCorrectos = true;
                    }
                    else
                    {
                        lbl_Mensaje.Text = "Introduzca una altura válida";
                        txtB_AlturaRectangulo.Focus();
                    }
                }
                else
                {
                    lbl_Mensaje.Text = "Introduzca una base válida";
                    txtB_BaseRectangulo.Focus();
                }
            }
            else if (chkB_Pentagono.Checked)
            {
                datosArea = "pentágono Base Altura"; ;
                if (txtB_LadoPentagono.Text != "" && Single.TryParse(txtB_LadoPentagono.Text, out float operando01))
                {
                    datosArea += " " + txtB_LadoPentagono.Text;
                    lbl_Mensaje.Text = "";
                    if (txtB_ApotemaPentagono.Text != "" && Single.TryParse(txtB_ApotemaPentagono.Text, out float operando02))
                    {
                        datosArea += " " + txtB_ApotemaPentagono.Text;
                        lbl_Mensaje.Text = "";
                        datosCorrectos = true;
                    }
                    else
                    {
                        lbl_Mensaje.Text = "Introduzca una apotema válida";
                        txtB_ApotemaPentagono.Focus();
                    }
                }
                else
                {
                    lbl_Mensaje.Text = "Introduzca un lado válido";
                    txtB_LadoPentagono.Focus();
                }
            }

            // Si los datos son correctos, escribimos datosArea en el writer para enviar la información al servidor
            if (datosCorrectos)
            {
                writer.WriteLine(datosArea);
                // Limpiamos el writer
                writer.Flush();
                // Mostramos el resultado recibido del servidor en la etiqueta de resultado
                lbl_Resultado.Text = reader.ReadLine();
                // Reiniciamos la variable datosCorrectos a false para comenzar de nuevo
                datosCorrectos = false;
            }
        }

        private void btn_FinalizarProceso_Click(object sender, EventArgs e)
        {
            // Paramos el proceso si no es nulo o no se ha salido
            int idProceso = proceso.Id;
            if (proceso != null && !proceso.HasExited)
            {
                proceso.Kill();
                proceso = null;
                // Cambiamos el texto que indica el estado del proceso con el Id
                lbl_EstadoProceso.Text = "Proceso Cálculo Finalizado ID: " + idProceso;
                // Reiniciamos todos los valores de Enabled en el formulario
                // para poder lanzar de nuevo el proceso si se desea
                ReiniciarEnabled();
            }
        }

        static Process StartServer(out Process proceso01)
        {
            // Creamos el objeto y la pasamos como argumento el ejecutable pipesServidor con el que se creará el proceso.
            ProcessStartInfo info = new ProcessStartInfo(@"..\..\..\..\PSP01 pipe\bin\Release\net6.0\win-x64\pipesServidor.exe");

            // Creamos una ventana nueva
            info.CreateNoWindow = false;

            // Creamos la ventana de tipo normal
            info.WindowStyle = ProcessWindowStyle.Normal;

            // La ventana se ejecutará cuando iniciemos el proceso.
            info.UseShellExecute = true;

            // Arrancamos el proceso y guarda sus datos en la variable proceso01
            proceso01 = Process.Start(info);

            return proceso01;
        }

        // Estos dos métodos reinician el estado y los datos del formulario a su valor inicial cuando se arranca el programa
        private void ReiniciarEnabled()
        {
            btn_Lanzar.Enabled = true;
            btn_Calcular.Enabled = false;
            lbl_Resultado.Enabled = false;
            btn_FinalizarProceso.Enabled = false;

            chkB_Circulo.Enabled = false;
            chkB_Triangulo.Enabled = false;
            chkB_Rectangulo.Enabled = false;
            chkB_Pentagono.Enabled = false;

            DatosDisabled();
        }

        private void DatosDisabled()
        {
            lbl_RadioCirculo.Enabled = false;
            lbl_BaseTriangulo.Enabled = false;
            lbl_BaseRectangulo.Enabled = false;
            lbl_LadoPentagono.Enabled = false;
            lbl_AlturaTriangulo.Enabled = false;
            lbl_AlturaRectangulo.Enabled = false;
            lbl_ApotemaPentagono.Enabled = false;

            txtB_RadioCirculo.Enabled = false;
            txtB_BaseTriangulo.Enabled = false;
            txtB_BaseRectangulo.Enabled = false;
            txtB_LadoPentagono.Enabled = false;
            txtB_AlturaTriangulo.Enabled = false;
            txtB_AlturaRectangulo.Enabled = false;
            txtB_ApotemaPentagono.Enabled = false;

            txtB_RadioCirculo.Text = "";
            txtB_BaseTriangulo.Text = "";
            txtB_BaseRectangulo.Text = "";
            txtB_LadoPentagono.Text = "";
            txtB_AlturaTriangulo.Text = "";
            txtB_AlturaRectangulo.Text = "";
            txtB_ApotemaPentagono.Text = "";

            lbl_Mensaje.Text = "";
            lbl_Resultado.Text = "";

            datosArea = string.Empty;
        }
    }
}