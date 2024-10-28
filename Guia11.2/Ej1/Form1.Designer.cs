namespace Ej1
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
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBpatente = new System.Windows.Forms.TextBox();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bImportar = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(120, 27);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 1;
            // 
            // tBpatente
            // 
            this.tBpatente.Location = new System.Drawing.Point(91, 59);
            this.tBpatente.Name = "tBpatente";
            this.tBpatente.Size = new System.Drawing.Size(200, 20);
            this.tBpatente.TabIndex = 2;
            this.tBpatente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(120, 88);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(100, 20);
            this.tBemail.TabIndex = 3;
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(120, 59);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(100, 20);
            this.tBdni.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos y Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Hoy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Patente";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(91, 19);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 12;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(470, 26);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(81, 74);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver VTV Realizados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(120, 259);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(200, 37);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Iniciar carga VTV";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(2, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 311);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros de VTV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tBdni);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tBnombre);
            this.groupBox3.Controls.Add(this.tBemail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(38, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 124);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del propietario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBpatente);
            this.groupBox2.Location = new System.Drawing.Point(48, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 93);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del vehiculo";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(470, 118);
            this.bImportar.Name = "bImportar";
            this.bImportar.Size = new System.Drawing.Size(81, 56);
            this.bImportar.TabIndex = 16;
            this.bImportar.Text = "Importar VTV";
            this.bImportar.UseVisualStyleBackColor = true;
            this.bImportar.Click += new System.EventHandler(this.bImportar_Click);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(470, 193);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(81, 50);
            this.bExportar.TabIndex = 17;
            this.bExportar.Text = "Exportar vehiculos";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 333);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.bImportar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBpatente;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.TextBox tBdni;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Button bExportar;
    }
}

