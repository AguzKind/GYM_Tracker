namespace App
{
    partial class FormPrincipal
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
            this.btn_AgregarProgreso = new System.Windows.Forms.Button();
            this.btn_VerProgreso = new System.Windows.Forms.Button();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pbx_imagen = new System.Windows.Forms.PictureBox();
            this.lbx_imagenes = new System.Windows.Forms.ListBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_AgregarImagen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_agregar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_subirContenido = new System.Windows.Forms.Button();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProgreso
            // 
            this.btn_AgregarProgreso.Location = new System.Drawing.Point(284, 249);
            this.btn_AgregarProgreso.Name = "btn_AgregarProgreso";
            this.btn_AgregarProgreso.Size = new System.Drawing.Size(151, 64);
            this.btn_AgregarProgreso.TabIndex = 0;
            this.btn_AgregarProgreso.Text = "Agregar Progreso";
            this.btn_AgregarProgreso.UseVisualStyleBackColor = true;
            this.btn_AgregarProgreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_VerProgreso
            // 
            this.btn_VerProgreso.Location = new System.Drawing.Point(493, 249);
            this.btn_VerProgreso.Name = "btn_VerProgreso";
            this.btn_VerProgreso.Size = new System.Drawing.Size(151, 64);
            this.btn_VerProgreso.TabIndex = 1;
            this.btn_VerProgreso.Text = "Ver Progreso";
            this.btn_VerProgreso.UseVisualStyleBackColor = true;
            this.btn_VerProgreso.Click += new System.EventHandler(this.btn_VerProgreso_Click);
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.btn_subirContenido);
            this.pnl_Info.Controls.Add(this.pbx_imagen);
            this.pnl_Info.Controls.Add(this.lbx_imagenes);
            this.pnl_Info.Controls.Add(this.btn_Menu);
            this.pnl_Info.Controls.Add(this.btn_AgregarImagen);
            this.pnl_Info.Controls.Add(this.label3);
            this.pnl_Info.Controls.Add(this.dtp_agregar);
            this.pnl_Info.Controls.Add(this.label2);
            this.pnl_Info.Controls.Add(this.txt_peso);
            this.pnl_Info.Controls.Add(this.label1);
            this.pnl_Info.Location = new System.Drawing.Point(12, 12);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(877, 548);
            this.pnl_Info.TabIndex = 3;
            this.pnl_Info.Visible = false;
            // 
            // pbx_imagen
            // 
            this.pbx_imagen.Location = new System.Drawing.Point(442, 17);
            this.pbx_imagen.Name = "pbx_imagen";
            this.pbx_imagen.Size = new System.Drawing.Size(404, 460);
            this.pbx_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_imagen.TabIndex = 9;
            this.pbx_imagen.TabStop = false;
            // 
            // lbx_imagenes
            // 
            this.lbx_imagenes.FormattingEnabled = true;
            this.lbx_imagenes.ItemHeight = 19;
            this.lbx_imagenes.Location = new System.Drawing.Point(3, 221);
            this.lbx_imagenes.Name = "lbx_imagenes";
            this.lbx_imagenes.Size = new System.Drawing.Size(393, 327);
            this.lbx_imagenes.TabIndex = 8;
            this.lbx_imagenes.SelectedIndexChanged += new System.EventHandler(this.lbx_imagenes_SelectedIndexChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(656, 483);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(190, 64);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "Volver al menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click_1);
            // 
            // btn_AgregarImagen
            // 
            this.btn_AgregarImagen.Location = new System.Drawing.Point(7, 125);
            this.btn_AgregarImagen.Name = "btn_AgregarImagen";
            this.btn_AgregarImagen.Size = new System.Drawing.Size(194, 64);
            this.btn_AgregarImagen.TabIndex = 5;
            this.btn_AgregarImagen.Text = "Agregar Imagenes...";
            this.btn_AgregarImagen.UseVisualStyleBackColor = true;
            this.btn_AgregarImagen.Click += new System.EventHandler(this.btn_AgregarImagen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(169, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kg.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtp_agregar
            // 
            this.dtp_agregar.CustomFormat = "yyyy/MM/dd";
            this.dtp_agregar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_agregar.Location = new System.Drawing.Point(66, 62);
            this.dtp_agregar.Name = "dtp_agregar";
            this.dtp_agregar.Size = new System.Drawing.Size(135, 27);
            this.dtp_agregar.TabIndex = 3;
            this.dtp_agregar.ValueChanged += new System.EventHandler(this.dtp_agregar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(66, 17);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 27);
            this.txt_peso.TabIndex = 1;
            this.txt_peso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_subirContenido
            // 
            this.btn_subirContenido.Location = new System.Drawing.Point(442, 484);
            this.btn_subirContenido.Name = "btn_subirContenido";
            this.btn_subirContenido.Size = new System.Drawing.Size(190, 64);
            this.btn_subirContenido.TabIndex = 10;
            this.btn_subirContenido.Text = "Subir contenido";
            this.btn_subirContenido.UseVisualStyleBackColor = true;
            this.btn_subirContenido.Click += new System.EventHandler(this.btn_subirContenido_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(901, 572);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.btn_VerProgreso);
            this.Controls.Add(this.btn_AgregarProgreso);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM Tracker";
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProgreso;
        private System.Windows.Forms.Button btn_VerProgreso;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.DateTimePicker dtp_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AgregarImagen;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.ListBox lbx_imagenes;
        private System.Windows.Forms.PictureBox pbx_imagen;
        private System.Windows.Forms.Button btn_subirContenido;
    }
}

