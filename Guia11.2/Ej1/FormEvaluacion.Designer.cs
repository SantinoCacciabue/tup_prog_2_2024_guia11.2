namespace Ej1
{
    partial class FormEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unidad = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBdesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBmedido = new System.Windows.Forms.TextBox();
            this.tBmaximo = new System.Windows.Forms.TextBox();
            this.tBminimo = new System.Windows.Forms.TextBox();
            this.lUnidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBfunciona = new System.Windows.Forms.CheckBox();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(38, 30);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // unidad
            // 
            this.unidad.AutoSize = true;
            this.unidad.Location = new System.Drawing.Point(217, 238);
            this.unidad.Name = "unidad";
            this.unidad.Size = new System.Drawing.Size(13, 13);
            this.unidad.TabIndex = 5;
            this.unidad.Text = "--";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(88, 59);
            this.tBnombre.Multiline = true;
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBnombre.Size = new System.Drawing.Size(211, 26);
            this.tBnombre.TabIndex = 6;
            // 
            // tBdesc
            // 
            this.tBdesc.Location = new System.Drawing.Point(88, 27);
            this.tBdesc.Multiline = true;
            this.tBdesc.Name = "tBdesc";
            this.tBdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBdesc.Size = new System.Drawing.Size(211, 26);
            this.tBdesc.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBmedido);
            this.groupBox1.Controls.Add(this.tBmaximo);
            this.groupBox1.Controls.Add(this.tBminimo);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBdesc);
            this.groupBox1.Controls.Add(this.lUnidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluación paramétrica";
            // 
            // tBmedido
            // 
            this.tBmedido.Location = new System.Drawing.Point(238, 143);
            this.tBmedido.Name = "tBmedido";
            this.tBmedido.Size = new System.Drawing.Size(81, 20);
            this.tBmedido.TabIndex = 7;
            // 
            // tBmaximo
            // 
            this.tBmaximo.Location = new System.Drawing.Point(151, 143);
            this.tBmaximo.Name = "tBmaximo";
            this.tBmaximo.Size = new System.Drawing.Size(81, 20);
            this.tBmaximo.TabIndex = 6;
            // 
            // tBminimo
            // 
            this.tBminimo.Location = new System.Drawing.Point(64, 143);
            this.tBminimo.Name = "tBminimo";
            this.tBminimo.Size = new System.Drawing.Size(81, 20);
            this.tBminimo.TabIndex = 5;
            // 
            // lUnidad
            // 
            this.lUnidad.AutoSize = true;
            this.lUnidad.Location = new System.Drawing.Point(334, 146);
            this.lUnidad.Name = "lUnidad";
            this.lUnidad.Size = new System.Drawing.Size(13, 13);
            this.lUnidad.TabIndex = 4;
            this.lUnidad.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor Medido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Máximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mínimo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBfunciona);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluación simple";
            // 
            // cBfunciona
            // 
            this.cBfunciona.AutoSize = true;
            this.cBfunciona.Location = new System.Drawing.Point(106, 19);
            this.cBfunciona.Name = "cBfunciona";
            this.cBfunciona.Size = new System.Drawing.Size(178, 17);
            this.cBfunciona.TabIndex = 0;
            this.cBfunciona.Text = "¿El funcionamiento es correcto?";
            this.cBfunciona.UseVisualStyleBackColor = true;
            // 
            // bSiguiente
            // 
            this.bSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSiguiente.Location = new System.Drawing.Point(174, 254);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(87, 30);
            this.bSiguiente.TabIndex = 10;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 299);
            this.Controls.Add(this.bSiguiente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unidad);
            this.Name = "FormEvaluacion";
            this.Text = "FormEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unidad;
        public System.Windows.Forms.TextBox tBnombre;
        public System.Windows.Forms.TextBox tBdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBminimo;
        public System.Windows.Forms.TextBox tBmedido;
        public System.Windows.Forms.TextBox tBmaximo;
        public System.Windows.Forms.CheckBox cBfunciona;
        public System.Windows.Forms.Button bSiguiente;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lUnidad;
    }
}