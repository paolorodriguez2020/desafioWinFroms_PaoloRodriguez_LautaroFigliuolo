
namespace ProyectoIntegrador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.checkMangaCorta = new System.Windows.Forms.CheckBox();
            this.rdCamisa = new System.Windows.Forms.RadioButton();
            this.rdPantalon = new System.Windows.Forms.RadioButton();
            this.checkBermuda = new System.Windows.Forms.CheckBox();
            this.rdbtnStandard = new System.Windows.Forms.RadioButton();
            this.rdbtnPremium = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3Precio = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3Cantidad = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3Precio.SuspendLayout();
            this.groupBox3Cantidad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VENTAS AL POR MAYOR -PradBit";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(12, 60);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(0, 13);
            this.lblsub.TabIndex = 1;
            // 
            // checkMangaCorta
            // 
            this.checkMangaCorta.AutoSize = true;
            this.checkMangaCorta.Location = new System.Drawing.Point(91, 19);
            this.checkMangaCorta.Name = "checkMangaCorta";
            this.checkMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkMangaCorta.TabIndex = 2;
            this.checkMangaCorta.Text = "Manga Corta";
            this.checkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rdCamisa
            // 
            this.rdCamisa.AutoSize = true;
            this.rdCamisa.Location = new System.Drawing.Point(14, 18);
            this.rdCamisa.Name = "rdCamisa";
            this.rdCamisa.Size = new System.Drawing.Size(59, 17);
            this.rdCamisa.TabIndex = 3;
            this.rdCamisa.TabStop = true;
            this.rdCamisa.Text = "Camisa";
            this.rdCamisa.UseVisualStyleBackColor = true;
            // 
            // rdPantalon
            // 
            this.rdPantalon.AutoSize = true;
            this.rdPantalon.Location = new System.Drawing.Point(14, 41);
            this.rdPantalon.Name = "rdPantalon";
            this.rdPantalon.Size = new System.Drawing.Size(70, 17);
            this.rdPantalon.TabIndex = 4;
            this.rdPantalon.TabStop = true;
            this.rdPantalon.Text = "Pantalon ";
            this.rdPantalon.UseVisualStyleBackColor = true;
            // 
            // checkBermuda
            // 
            this.checkBermuda.AutoSize = true;
            this.checkBermuda.Location = new System.Drawing.Point(91, 42);
            this.checkBermuda.Name = "checkBermuda";
            this.checkBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBermuda.TabIndex = 5;
            this.checkBermuda.Text = "Bermuda";
            this.checkBermuda.UseVisualStyleBackColor = true;
            // 
            // rdbtnStandard
            // 
            this.rdbtnStandard.AutoSize = true;
            this.rdbtnStandard.Location = new System.Drawing.Point(6, 19);
            this.rdbtnStandard.Name = "rdbtnStandard";
            this.rdbtnStandard.Size = new System.Drawing.Size(71, 17);
            this.rdbtnStandard.TabIndex = 7;
            this.rdbtnStandard.TabStop = true;
            this.rdbtnStandard.Text = "Standard ";
            this.rdbtnStandard.UseVisualStyleBackColor = true;
            // 
            // rdbtnPremium
            // 
            this.rdbtnPremium.AutoSize = true;
            this.rdbtnPremium.Location = new System.Drawing.Point(98, 19);
            this.rdbtnPremium.Name = "rdbtnPremium";
            this.rdbtnPremium.Size = new System.Drawing.Size(68, 17);
            this.rdbtnPremium.TabIndex = 8;
            this.rdbtnPremium.TabStop = true;
            this.rdbtnPremium.Text = "Premium ";
            this.rdbtnPremium.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Location = new System.Drawing.Point(12, 325);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(237, 50);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcula Precio Final ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkMangaCorta);
            this.groupBox1.Controls.Add(this.rdCamisa);
            this.groupBox1.Controls.Add(this.rdPantalon);
            this.groupBox1.Controls.Add(this.checkBermuda);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Prenda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnStandard);
            this.groupBox2.Controls.Add(this.rdbtnPremium);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de Prenda";
            // 
            // groupBox3Precio
            // 
            this.groupBox3Precio.Controls.Add(this.textBox1);
            this.groupBox3Precio.Location = new System.Drawing.Point(18, 266);
            this.groupBox3Precio.Name = "groupBox3Precio";
            this.groupBox3Precio.Size = new System.Drawing.Size(109, 40);
            this.groupBox3Precio.TabIndex = 15;
            this.groupBox3Precio.TabStop = false;
            this.groupBox3Precio.Text = "Precio ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3Cantidad
            // 
            this.groupBox3Cantidad.Controls.Add(this.textBox2);
            this.groupBox3Cantidad.Location = new System.Drawing.Point(133, 266);
            this.groupBox3Cantidad.Name = "groupBox3Cantidad";
            this.groupBox3Cantidad.Size = new System.Drawing.Size(116, 40);
            this.groupBox3Cantidad.TabIndex = 16;
            this.groupBox3Cantidad.TabStop = false;
            this.groupBox3Cantidad.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPrecioFinal);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 74);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Precio Final ";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(143, 26);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioFinal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox3Cantidad);
            this.Controls.Add(this.groupBox3Precio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3Precio.ResumeLayout(false);
            this.groupBox3Precio.PerformLayout();
            this.groupBox3Cantidad.ResumeLayout(false);
            this.groupBox3Cantidad.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.CheckBox checkMangaCorta;
        private System.Windows.Forms.RadioButton rdCamisa;
        private System.Windows.Forms.RadioButton rdPantalon;
        private System.Windows.Forms.CheckBox checkBermuda;
        private System.Windows.Forms.RadioButton rdbtnStandard;
        private System.Windows.Forms.RadioButton rdbtnPremium;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3Precio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3Cantidad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lbl;
    }
}

