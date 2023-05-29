namespace pipeForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Lanzar = new System.Windows.Forms.Button();
            this.lbl_EstadoProceso = new System.Windows.Forms.Label();
            this.chkB_Circulo = new System.Windows.Forms.CheckBox();
            this.lbl_RadioCirculo = new System.Windows.Forms.Label();
            this.txtB_RadioCirculo = new System.Windows.Forms.TextBox();
            this.txtB_BaseTriangulo = new System.Windows.Forms.TextBox();
            this.lbl_BaseTriangulo = new System.Windows.Forms.Label();
            this.chkB_Triangulo = new System.Windows.Forms.CheckBox();
            this.txtB_BaseRectangulo = new System.Windows.Forms.TextBox();
            this.lbl_BaseRectangulo = new System.Windows.Forms.Label();
            this.chkB_Rectangulo = new System.Windows.Forms.CheckBox();
            this.txtB_LadoPentagono = new System.Windows.Forms.TextBox();
            this.lbl_LadoPentagono = new System.Windows.Forms.Label();
            this.chkB_Pentagono = new System.Windows.Forms.CheckBox();
            this.txtB_ApotemaPentagono = new System.Windows.Forms.TextBox();
            this.lbl_ApotemaPentagono = new System.Windows.Forms.Label();
            this.txtB_AlturaRectangulo = new System.Windows.Forms.TextBox();
            this.lbl_AlturaRectangulo = new System.Windows.Forms.Label();
            this.txtB_AlturaTriangulo = new System.Windows.Forms.TextBox();
            this.lbl_AlturaTriangulo = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_FinalizarProceso = new System.Windows.Forms.Button();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Lanzar
            // 
            this.btn_Lanzar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Lanzar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Lanzar.Location = new System.Drawing.Point(64, 40);
            this.btn_Lanzar.Name = "btn_Lanzar";
            this.btn_Lanzar.Size = new System.Drawing.Size(142, 42);
            this.btn_Lanzar.TabIndex = 0;
            this.btn_Lanzar.Text = "Lanzar el proceso";
            this.btn_Lanzar.UseVisualStyleBackColor = false;
            this.btn_Lanzar.Click += new System.EventHandler(this.btn_Lanzar_Click);
            // 
            // lbl_EstadoProceso
            // 
            this.lbl_EstadoProceso.AutoSize = true;
            this.lbl_EstadoProceso.Location = new System.Drawing.Point(235, 54);
            this.lbl_EstadoProceso.Name = "lbl_EstadoProceso";
            this.lbl_EstadoProceso.Size = new System.Drawing.Size(132, 15);
            this.lbl_EstadoProceso.TabIndex = 1;
            this.lbl_EstadoProceso.Text = "Proceso Cálculo Parado";
            // 
            // chkB_Circulo
            // 
            this.chkB_Circulo.AutoSize = true;
            this.chkB_Circulo.Enabled = false;
            this.chkB_Circulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkB_Circulo.Location = new System.Drawing.Point(64, 131);
            this.chkB_Circulo.Name = "chkB_Circulo";
            this.chkB_Circulo.Size = new System.Drawing.Size(93, 19);
            this.chkB_Circulo.TabIndex = 2;
            this.chkB_Circulo.Text = "Area Círculo";
            this.chkB_Circulo.UseVisualStyleBackColor = true;
            this.chkB_Circulo.CheckedChanged += new System.EventHandler(this.chkB_Circulo_CheckedChanged);
            // 
            // lbl_RadioCirculo
            // 
            this.lbl_RadioCirculo.AutoSize = true;
            this.lbl_RadioCirculo.Enabled = false;
            this.lbl_RadioCirculo.Location = new System.Drawing.Point(198, 133);
            this.lbl_RadioCirculo.Name = "lbl_RadioCirculo";
            this.lbl_RadioCirculo.Size = new System.Drawing.Size(123, 15);
            this.lbl_RadioCirculo.TabIndex = 3;
            this.lbl_RadioCirculo.Text = "Radio del círculo (cm)";
            // 
            // txtB_RadioCirculo
            // 
            this.txtB_RadioCirculo.Enabled = false;
            this.txtB_RadioCirculo.Location = new System.Drawing.Point(346, 129);
            this.txtB_RadioCirculo.Name = "txtB_RadioCirculo";
            this.txtB_RadioCirculo.Size = new System.Drawing.Size(100, 23);
            this.txtB_RadioCirculo.TabIndex = 4;
            // 
            // txtB_BaseTriangulo
            // 
            this.txtB_BaseTriangulo.Enabled = false;
            this.txtB_BaseTriangulo.Location = new System.Drawing.Point(346, 172);
            this.txtB_BaseTriangulo.Name = "txtB_BaseTriangulo";
            this.txtB_BaseTriangulo.Size = new System.Drawing.Size(100, 23);
            this.txtB_BaseTriangulo.TabIndex = 7;
            // 
            // lbl_BaseTriangulo
            // 
            this.lbl_BaseTriangulo.AutoSize = true;
            this.lbl_BaseTriangulo.Enabled = false;
            this.lbl_BaseTriangulo.Location = new System.Drawing.Point(198, 176);
            this.lbl_BaseTriangulo.Name = "lbl_BaseTriangulo";
            this.lbl_BaseTriangulo.Size = new System.Drawing.Size(129, 15);
            this.lbl_BaseTriangulo.TabIndex = 6;
            this.lbl_BaseTriangulo.Text = "Base del triángulo (cm)";
            // 
            // chkB_Triangulo
            // 
            this.chkB_Triangulo.AutoSize = true;
            this.chkB_Triangulo.Enabled = false;
            this.chkB_Triangulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkB_Triangulo.Location = new System.Drawing.Point(64, 174);
            this.chkB_Triangulo.Name = "chkB_Triangulo";
            this.chkB_Triangulo.Size = new System.Drawing.Size(106, 19);
            this.chkB_Triangulo.TabIndex = 5;
            this.chkB_Triangulo.Text = "Area Triángulo";
            this.chkB_Triangulo.UseVisualStyleBackColor = true;
            this.chkB_Triangulo.CheckedChanged += new System.EventHandler(this.chkB_Triangulo_CheckedChanged);
            // 
            // txtB_BaseRectangulo
            // 
            this.txtB_BaseRectangulo.Enabled = false;
            this.txtB_BaseRectangulo.Location = new System.Drawing.Point(346, 213);
            this.txtB_BaseRectangulo.Name = "txtB_BaseRectangulo";
            this.txtB_BaseRectangulo.Size = new System.Drawing.Size(100, 23);
            this.txtB_BaseRectangulo.TabIndex = 10;
            // 
            // lbl_BaseRectangulo
            // 
            this.lbl_BaseRectangulo.AutoSize = true;
            this.lbl_BaseRectangulo.Enabled = false;
            this.lbl_BaseRectangulo.Location = new System.Drawing.Point(198, 217);
            this.lbl_BaseRectangulo.Name = "lbl_BaseRectangulo";
            this.lbl_BaseRectangulo.Size = new System.Drawing.Size(138, 15);
            this.lbl_BaseRectangulo.TabIndex = 9;
            this.lbl_BaseRectangulo.Text = "Base del rectángulo (cm)";
            // 
            // chkB_Rectangulo
            // 
            this.chkB_Rectangulo.AutoSize = true;
            this.chkB_Rectangulo.Enabled = false;
            this.chkB_Rectangulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkB_Rectangulo.Location = new System.Drawing.Point(64, 215);
            this.chkB_Rectangulo.Name = "chkB_Rectangulo";
            this.chkB_Rectangulo.Size = new System.Drawing.Size(118, 19);
            this.chkB_Rectangulo.TabIndex = 8;
            this.chkB_Rectangulo.Text = "Area Rectángulo";
            this.chkB_Rectangulo.UseVisualStyleBackColor = true;
            this.chkB_Rectangulo.CheckedChanged += new System.EventHandler(this.chkB_Rectangulo_CheckedChanged);
            // 
            // txtB_LadoPentagono
            // 
            this.txtB_LadoPentagono.Enabled = false;
            this.txtB_LadoPentagono.Location = new System.Drawing.Point(346, 255);
            this.txtB_LadoPentagono.Name = "txtB_LadoPentagono";
            this.txtB_LadoPentagono.Size = new System.Drawing.Size(100, 23);
            this.txtB_LadoPentagono.TabIndex = 13;
            // 
            // lbl_LadoPentagono
            // 
            this.lbl_LadoPentagono.AutoSize = true;
            this.lbl_LadoPentagono.Enabled = false;
            this.lbl_LadoPentagono.Location = new System.Drawing.Point(198, 259);
            this.lbl_LadoPentagono.Name = "lbl_LadoPentagono";
            this.lbl_LadoPentagono.Size = new System.Drawing.Size(141, 15);
            this.lbl_LadoPentagono.TabIndex = 12;
            this.lbl_LadoPentagono.Text = "Lado del pentágono (cm)";
            // 
            // chkB_Pentagono
            // 
            this.chkB_Pentagono.AutoSize = true;
            this.chkB_Pentagono.Enabled = false;
            this.chkB_Pentagono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkB_Pentagono.Location = new System.Drawing.Point(64, 257);
            this.chkB_Pentagono.Name = "chkB_Pentagono";
            this.chkB_Pentagono.Size = new System.Drawing.Size(115, 19);
            this.chkB_Pentagono.TabIndex = 11;
            this.chkB_Pentagono.Text = "Area Pentágono";
            this.chkB_Pentagono.UseVisualStyleBackColor = true;
            this.chkB_Pentagono.CheckedChanged += new System.EventHandler(this.chkB_Pentagono_CheckedChanged);
            // 
            // txtB_ApotemaPentagono
            // 
            this.txtB_ApotemaPentagono.Enabled = false;
            this.txtB_ApotemaPentagono.Location = new System.Drawing.Point(635, 255);
            this.txtB_ApotemaPentagono.Name = "txtB_ApotemaPentagono";
            this.txtB_ApotemaPentagono.Size = new System.Drawing.Size(100, 23);
            this.txtB_ApotemaPentagono.TabIndex = 21;
            // 
            // lbl_ApotemaPentagono
            // 
            this.lbl_ApotemaPentagono.AutoSize = true;
            this.lbl_ApotemaPentagono.Enabled = false;
            this.lbl_ApotemaPentagono.Location = new System.Drawing.Point(464, 259);
            this.lbl_ApotemaPentagono.Name = "lbl_ApotemaPentagono";
            this.lbl_ApotemaPentagono.Size = new System.Drawing.Size(164, 15);
            this.lbl_ApotemaPentagono.TabIndex = 20;
            this.lbl_ApotemaPentagono.Text = "Apotema del pentágono (cm)";
            // 
            // txtB_AlturaRectangulo
            // 
            this.txtB_AlturaRectangulo.Enabled = false;
            this.txtB_AlturaRectangulo.Location = new System.Drawing.Point(635, 213);
            this.txtB_AlturaRectangulo.Name = "txtB_AlturaRectangulo";
            this.txtB_AlturaRectangulo.Size = new System.Drawing.Size(100, 23);
            this.txtB_AlturaRectangulo.TabIndex = 19;
            // 
            // lbl_AlturaRectangulo
            // 
            this.lbl_AlturaRectangulo.AutoSize = true;
            this.lbl_AlturaRectangulo.Enabled = false;
            this.lbl_AlturaRectangulo.Location = new System.Drawing.Point(464, 217);
            this.lbl_AlturaRectangulo.Name = "lbl_AlturaRectangulo";
            this.lbl_AlturaRectangulo.Size = new System.Drawing.Size(146, 15);
            this.lbl_AlturaRectangulo.TabIndex = 18;
            this.lbl_AlturaRectangulo.Text = "Altura del rectángulo (cm)";
            // 
            // txtB_AlturaTriangulo
            // 
            this.txtB_AlturaTriangulo.Enabled = false;
            this.txtB_AlturaTriangulo.Location = new System.Drawing.Point(635, 172);
            this.txtB_AlturaTriangulo.Name = "txtB_AlturaTriangulo";
            this.txtB_AlturaTriangulo.Size = new System.Drawing.Size(100, 23);
            this.txtB_AlturaTriangulo.TabIndex = 17;
            // 
            // lbl_AlturaTriangulo
            // 
            this.lbl_AlturaTriangulo.AutoSize = true;
            this.lbl_AlturaTriangulo.Enabled = false;
            this.lbl_AlturaTriangulo.Location = new System.Drawing.Point(464, 176);
            this.lbl_AlturaTriangulo.Name = "lbl_AlturaTriangulo";
            this.lbl_AlturaTriangulo.Size = new System.Drawing.Size(137, 15);
            this.lbl_AlturaTriangulo.TabIndex = 16;
            this.lbl_AlturaTriangulo.Text = "Altura del triángulo (cm)";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Calcular.Enabled = false;
            this.btn_Calcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calcular.Location = new System.Drawing.Point(64, 320);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(142, 42);
            this.btn_Calcular.TabIndex = 22;
            this.btn_Calcular.Text = "Calcular el Area";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Enabled = false;
            this.lbl_Resultado.Location = new System.Drawing.Point(235, 334);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(103, 15);
            this.lbl_Resultado.TabIndex = 23;
            this.lbl_Resultado.Text = "Mostrar Resultado";
            // 
            // btn_FinalizarProceso
            // 
            this.btn_FinalizarProceso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_FinalizarProceso.Enabled = false;
            this.btn_FinalizarProceso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FinalizarProceso.Location = new System.Drawing.Point(593, 366);
            this.btn_FinalizarProceso.Name = "btn_FinalizarProceso";
            this.btn_FinalizarProceso.Size = new System.Drawing.Size(142, 42);
            this.btn_FinalizarProceso.TabIndex = 24;
            this.btn_FinalizarProceso.Text = "Finalizar el proceso";
            this.btn_FinalizarProceso.UseVisualStyleBackColor = false;
            this.btn_FinalizarProceso.Click += new System.EventHandler(this.btn_FinalizarProceso_Click);
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mensaje.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Mensaje.Location = new System.Drawing.Point(64, 400);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(0, 15);
            this.lbl_Mensaje.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.btn_FinalizarProceso);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtB_ApotemaPentagono);
            this.Controls.Add(this.lbl_ApotemaPentagono);
            this.Controls.Add(this.txtB_AlturaRectangulo);
            this.Controls.Add(this.lbl_AlturaRectangulo);
            this.Controls.Add(this.txtB_AlturaTriangulo);
            this.Controls.Add(this.lbl_AlturaTriangulo);
            this.Controls.Add(this.txtB_LadoPentagono);
            this.Controls.Add(this.lbl_LadoPentagono);
            this.Controls.Add(this.chkB_Pentagono);
            this.Controls.Add(this.txtB_BaseRectangulo);
            this.Controls.Add(this.lbl_BaseRectangulo);
            this.Controls.Add(this.chkB_Rectangulo);
            this.Controls.Add(this.txtB_BaseTriangulo);
            this.Controls.Add(this.lbl_BaseTriangulo);
            this.Controls.Add(this.chkB_Triangulo);
            this.Controls.Add(this.txtB_RadioCirculo);
            this.Controls.Add(this.lbl_RadioCirculo);
            this.Controls.Add(this.chkB_Circulo);
            this.Controls.Add(this.lbl_EstadoProceso);
            this.Controls.Add(this.btn_Lanzar);
            this.Name = "Form1";
            this.Text = "Cálculo de áreas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Lanzar;
        private Label lbl_EstadoProceso;
        private CheckBox chkB_Circulo;
        private Label lbl_RadioCirculo;
        private TextBox txtB_RadioCirculo;
        private TextBox txtB_BaseTriangulo;
        private Label lbl_BaseTriangulo;
        private CheckBox chkB_Triangulo;
        private TextBox txtB_BaseRectangulo;
        private Label lbl_BaseRectangulo;
        private CheckBox chkB_Rectangulo;
        private TextBox txtB_LadoPentagono;
        private Label lbl_LadoPentagono;
        private CheckBox chkB_Pentagono;
        private TextBox txtB_ApotemaPentagono;
        private Label lbl_ApotemaPentagono;
        private TextBox txtB_AlturaRectangulo;
        private Label lbl_AlturaRectangulo;
        private TextBox txtB_AlturaTriangulo;
        private Label lbl_AlturaTriangulo;
        private Button btn_Calcular;
        private Label lbl_Resultado;
        private Button btn_FinalizarProceso;
        private Label lbl_Mensaje;
    }
}