namespace practicar
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
            texCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textNombre = new TextBox();
            label3 = new Label();
            textSueldo = new TextBox();
            label4 = new Label();
            textHoras = new TextBox();
            CboTipoSeguro = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cboArea1 = new ComboBox();
            texResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // texCodigo
            // 
            texCodigo.Location = new Point(37, 46);
            texCodigo.Name = "texCodigo";
            texCodigo.Size = new Size(125, 27);
            texCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(221, 46);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(222, 27);
            textNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 103);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Sueldo";
            // 
            // textSueldo
            // 
            textSueldo.Location = new Point(37, 140);
            textSueldo.Name = "textSueldo";
            textSueldo.Size = new Size(125, 27);
            textSueldo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 103);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 8;
            label4.Text = "Horas Extras";
            // 
            // textHoras
            // 
            textHoras.Location = new Point(221, 140);
            textHoras.Name = "textHoras";
            textHoras.Size = new Size(125, 27);
            textHoras.TabIndex = 7;
            // 
            // CboTipoSeguro
            // 
            CboTipoSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoSeguro.FormattingEnabled = true;
            CboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            CboTipoSeguro.Location = new Point(484, 46);
            CboTipoSeguro.Name = "CboTipoSeguro";
            CboTipoSeguro.Size = new Size(151, 28);
            CboTipoSeguro.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 9);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "Tipo Seguro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 102);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 12;
            label6.Text = "Area";
            // 
            // cboArea1
            // 
            cboArea1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea1.FormattingEnabled = true;
            cboArea1.Items.AddRange(new object[] { "ADMINISTRACIÓN", "CONTABILIDAD", "ALMACEN" });
            cboArea1.Location = new Point(484, 139);
            cboArea1.Name = "cboArea1";
            cboArea1.Size = new Size(151, 28);
            cboArea1.TabIndex = 11;
            // 
            // texResultado
            // 
            texResultado.Location = new Point(37, 188);
            texResultado.Multiline = true;
            texResultado.Name = "texResultado";
            texResultado.Size = new Size(598, 215);
            texResultado.TabIndex = 13;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(25, 409);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(137, 29);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(209, 409);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(252, 29);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar informacion del objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(484, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(627, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(texResultado);
            Controls.Add(label6);
            Controls.Add(cboArea1);
            Controls.Add(label5);
            Controls.Add(CboTipoSeguro);
            Controls.Add(label4);
            Controls.Add(textHoras);
            Controls.Add(label3);
            Controls.Add(textSueldo);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Controls.Add(texCodigo);
            Name = "Form1";
            Text = "Gestion de planillas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox texCodigo;
        private Label label1;
        private Label label2;
        private TextBox textNombre;
        private Label label3;
        private TextBox textSueldo;
        private Label label4;
        private TextBox textHoras;
        private ComboBox CboTipoSeguro;
        private Label label5;
        private Label label6;
        private ComboBox cboArea1;
        private TextBox texResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
