namespace Practica_1_EDT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNivDeTanque = new System.Windows.Forms.Label();
            this.txtSensorUno = new System.Windows.Forms.Label();
            this.txtSensor2 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(105, 35);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(28, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Cifra";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(146, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(262, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Dale!";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(21, 83);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(29, 13);
            this.lblDir.TabIndex = 4;
            this.lblDir.Text = "Way";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sensor 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sensor 2";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(234, 247);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(30, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Date";
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(146, 279);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(200, 20);
            this.dtpFechas.TabIndex = 12;
            this.dtpFechas.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_1_EDT.Properties.Resources.SO;
            this.pictureBox1.Location = new System.Drawing.Point(5, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtNivDeTanque
            // 
            this.txtNivDeTanque.AutoSize = true;
            this.txtNivDeTanque.Location = new System.Drawing.Point(138, 106);
            this.txtNivDeTanque.Name = "txtNivDeTanque";
            this.txtNivDeTanque.Size = new System.Drawing.Size(0, 13);
            this.txtNivDeTanque.TabIndex = 15;
            // 
            // txtSensorUno
            // 
            this.txtSensorUno.AutoSize = true;
            this.txtSensorUno.Location = new System.Drawing.Point(328, 138);
            this.txtSensorUno.Name = "txtSensorUno";
            this.txtSensorUno.Size = new System.Drawing.Size(0, 13);
            this.txtSensorUno.TabIndex = 16;
            // 
            // txtSensor2
            // 
            this.txtSensor2.AutoSize = true;
            this.txtSensor2.Location = new System.Drawing.Point(475, 138);
            this.txtSensor2.Name = "txtSensor2";
            this.txtSensor2.Size = new System.Drawing.Size(0, 13);
            this.txtSensor2.TabIndex = 17;
            this.txtSensor2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.AutoSize = true;
            this.txtFechaFinal.Location = new System.Drawing.Point(234, 330);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(0, 13);
            this.txtFechaFinal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 495);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.txtSensor2);
            this.Controls.Add(this.txtSensorUno);
            this.Controls.Add(this.txtNivDeTanque);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFechas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Label txtNivDeTanque;
        private System.Windows.Forms.Label txtSensorUno;
        private System.Windows.Forms.Label txtSensor2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtFechaFinal;
    }
}

