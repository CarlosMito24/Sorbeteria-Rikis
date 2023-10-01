namespace Sorbeteria_Riki_s
{
    partial class FormulariodeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulariodeCompra));
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.TextBoxCantidad = new System.Windows.Forms.TextBox();
            this.ComboBoxTipos = new System.Windows.Forms.ComboBox();
            this.BotonEfectuarCompra = new System.Windows.Forms.Button();
            this.BotónFormulariodeVentas = new System.Windows.Forms.Button();
            this.BotónRegistroDeVentas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BotonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonAgregar.FlatAppearance.BorderSize = 5;
            this.BotonAgregar.Location = new System.Drawing.Point(920, 560);
            this.BotonAgregar.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(200, 100);
            this.BotonAgregar.TabIndex = 0;
            this.BotonAgregar.Text = "Agregar Más Conos";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            // 
            // TextBoxCantidad
            // 
            this.TextBoxCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCantidad.Location = new System.Drawing.Point(400, 250);
            this.TextBoxCantidad.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.TextBoxCantidad.Name = "TextBoxCantidad";
            this.TextBoxCantidad.Size = new System.Drawing.Size(350, 30);
            this.TextBoxCantidad.TabIndex = 2;
            // 
            // ComboBoxTipos
            // 
            this.ComboBoxTipos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTipos.FormattingEnabled = true;
            this.ComboBoxTipos.Items.AddRange(new object[] {
            "Cono Simple ",
            "Cono Simple - Doble Bola",
            "Cono Chocolate - Simple",
            "Cono Chocolate - Doble Bola"});
            this.ComboBoxTipos.Location = new System.Drawing.Point(400, 350);
            this.ComboBoxTipos.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxTipos.Name = "ComboBoxTipos";
            this.ComboBoxTipos.Size = new System.Drawing.Size(350, 31);
            this.ComboBoxTipos.TabIndex = 4;
            // 
            // BotonEfectuarCompra
            // 
            this.BotonEfectuarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonEfectuarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BotonEfectuarCompra.Location = new System.Drawing.Point(1130, 560);
            this.BotonEfectuarCompra.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.BotonEfectuarCompra.Name = "BotonEfectuarCompra";
            this.BotonEfectuarCompra.Size = new System.Drawing.Size(200, 100);
            this.BotonEfectuarCompra.TabIndex = 5;
            this.BotonEfectuarCompra.Text = "Efectuar Compra";
            this.BotonEfectuarCompra.UseVisualStyleBackColor = false;
            this.BotonEfectuarCompra.Click += new System.EventHandler(this.BotonEfectuarCompra_Click);
            // 
            // BotónFormulariodeVentas
            // 
            this.BotónFormulariodeVentas.AutoSize = true;
            this.BotónFormulariodeVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotónFormulariodeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotónFormulariodeVentas.Location = new System.Drawing.Point(10, 10);
            this.BotónFormulariodeVentas.Margin = new System.Windows.Forms.Padding(0);
            this.BotónFormulariodeVentas.Name = "BotónFormulariodeVentas";
            this.BotónFormulariodeVentas.Size = new System.Drawing.Size(324, 75);
            this.BotónFormulariodeVentas.TabIndex = 6;
            this.BotónFormulariodeVentas.Text = "Formulario de Ventas";
            this.BotónFormulariodeVentas.UseVisualStyleBackColor = false;
            // 
            // BotónRegistroDeVentas
            // 
            this.BotónRegistroDeVentas.AutoSize = true;
            this.BotónRegistroDeVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotónRegistroDeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotónRegistroDeVentas.Location = new System.Drawing.Point(10, 95);
            this.BotónRegistroDeVentas.Margin = new System.Windows.Forms.Padding(0);
            this.BotónRegistroDeVentas.Name = "BotónRegistroDeVentas";
            this.BotónRegistroDeVentas.Size = new System.Drawing.Size(324, 75);
            this.BotónRegistroDeVentas.TabIndex = 7;
            this.BotónRegistroDeVentas.Text = "Registro de Ventas";
            this.BotónRegistroDeVentas.UseVisualStyleBackColor = false;
            this.BotónRegistroDeVentas.Click += new System.EventHandler(this.BotónRegistroDeVentas_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(10, 180);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 75);
            this.button3.TabIndex = 8;
            this.button3.Text = "Menú";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingresa la cantidad de conos que deseas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecciona el tipo de cono que deseas:";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(10, 265);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 75);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 250);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(400, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingresa un nombre de comprador";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(400, 400);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(58, 23);
            this.LabelTotal.TabIndex = 17;
            this.LabelTotal.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "Formulario de Ventas";
            // 
            // FormulariodeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 683);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BotónRegistroDeVentas);
            this.Controls.Add(this.BotónFormulariodeVentas);
            this.Controls.Add(this.BotonEfectuarCompra);
            this.Controls.Add(this.ComboBoxTipos);
            this.Controls.Add(this.TextBoxCantidad);
            this.Controls.Add(this.BotonAgregar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormulariodeCompra";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorbeteria Riki´s ";
            this.Load += new System.EventHandler(this.FormulariodeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox TextBoxCantidad;
        private System.Windows.Forms.ComboBox ComboBoxTipos;
        private System.Windows.Forms.Button BotonEfectuarCompra;
        private System.Windows.Forms.Button BotónFormulariodeVentas;
        private System.Windows.Forms.Button BotónRegistroDeVentas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label4;
    }
}

