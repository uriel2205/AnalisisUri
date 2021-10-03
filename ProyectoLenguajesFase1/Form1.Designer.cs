namespace AnalisisUri
{
    partial class FormProyecto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardaHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEntrada = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSalida = new System.Windows.Forms.RichTextBox();
            this.dataLexemas = new System.Windows.Forms.DataGridView();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataErrores = new System.Windows.Forms.DataGridView();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbngenerar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardaHTMLToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrir
            // 
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(173, 26);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardaHTMLToolStripMenuItem
            // 
            this.guardaHTMLToolStripMenuItem.Name = "guardaHTMLToolStripMenuItem";
            this.guardaHTMLToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.guardaHTMLToolStripMenuItem.Text = "Guarda XML";
            this.guardaHTMLToolStripMenuItem.Click += new System.EventHandler(this.guardaHTMLToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(24, 80);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(589, 419);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSalida
            // 
            this.txtSalida.Enabled = false;
            this.txtSalida.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(24, 521);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(589, 316);
            this.txtSalida.TabIndex = 2;
            this.txtSalida.Text = "";
            // 
            // dataLexemas
            // 
            this.dataLexemas.AllowUserToDeleteRows = false;
            this.dataLexemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLexemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Token});
            this.dataLexemas.Location = new System.Drawing.Point(664, 426);
            this.dataLexemas.Name = "dataLexemas";
            this.dataLexemas.ReadOnly = true;
            this.dataLexemas.RowHeadersWidth = 51;
            this.dataLexemas.RowTemplate.Height = 24;
            this.dataLexemas.Size = new System.Drawing.Size(570, 279);
            this.dataLexemas.TabIndex = 5;
            // 
            // Lexema
            // 
            this.Lexema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 6;
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 86;
            // 
            // Token
            // 
            this.Token.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Width = 77;
            // 
            // dataErrores
            // 
            this.dataErrores.AllowUserToDeleteRows = false;
            this.dataErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Error,
            this.Token2});
            this.dataErrores.Location = new System.Drawing.Point(664, 123);
            this.dataErrores.Name = "dataErrores";
            this.dataErrores.ReadOnly = true;
            this.dataErrores.RowHeadersWidth = 51;
            this.dataErrores.RowTemplate.Height = 24;
            this.dataErrores.Size = new System.Drawing.Size(570, 228);
            this.dataErrores.TabIndex = 6;
            // 
            // Error
            // 
            this.Error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Error.HeaderText = "Error";
            this.Error.MinimumWidth = 6;
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            this.Error.Width = 69;
            // 
            // Token2
            // 
            this.Token2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Token2.HeaderText = "Token";
            this.Token2.MinimumWidth = 6;
            this.Token2.Name = "Token2";
            this.Token2.ReadOnly = true;
            this.Token2.Width = 77;
            // 
            // tbngenerar
            // 
            this.tbngenerar.Location = new System.Drawing.Point(834, 748);
            this.tbngenerar.Name = "tbngenerar";
            this.tbngenerar.Size = new System.Drawing.Size(175, 65);
            this.tbngenerar.TabIndex = 9;
            this.tbngenerar.Text = "Analizar y Generar";
            this.tbngenerar.UseVisualStyleBackColor = true;
            this.tbngenerar.Click += new System.EventHandler(this.tbngenerar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(825, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Analisis Lexico";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(825, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Analisis Sintatico";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(168, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Archivo de Entrada";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 843);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbngenerar);
            this.Controls.Add(this.dataErrores);
            this.Controls.Add(this.dataLexemas);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProyecto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtEntrada;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem guardaHTMLToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtSalida;
        private System.Windows.Forms.DataGridView dataLexemas;
        private System.Windows.Forms.DataGridView dataErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token2;
        private System.Windows.Forms.Button tbngenerar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

