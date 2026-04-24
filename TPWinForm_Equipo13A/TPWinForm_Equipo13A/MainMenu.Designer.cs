namespace TPWinForm_Equipo13A
{
    partial class MainMenu
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
            this.btnListadoArt = new System.Windows.Forms.Button();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.Text_info = new System.Windows.Forms.Label();
            this.criterioBusqueda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListadoArt
            // 
            this.btnListadoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoArt.Location = new System.Drawing.Point(37, 378);
            this.btnListadoArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListadoArt.Name = "btnListadoArt";
            this.btnListadoArt.Size = new System.Drawing.Size(729, 47);
            this.btnListadoArt.TabIndex = 0;
            this.btnListadoArt.Text = "Listado de Artículos";
            this.btnListadoArt.UseVisualStyleBackColor = true;
            this.btnListadoArt.Click += new System.EventHandler(this.btnListadoArt_Click);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(293, 38);
            this.textBox_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(203, 22);
            this.textBox_usuario.TabIndex = 1;
            this.textBox_usuario.TextChanged += new System.EventHandler(this.textBox_usuario_TextChanged);
            // 
            // Text_info
            // 
            this.Text_info.AutoSize = true;
            this.Text_info.Location = new System.Drawing.Point(33, 42);
            this.Text_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text_info.Name = "Text_info";
            this.Text_info.Size = new System.Drawing.Size(238, 16);
            this.Text_info.TabIndex = 2;
            this.Text_info.Text = "Ingrese el nombre del articulo a buscar";
            this.Text_info.Click += new System.EventHandler(this.Ingrese_Click);
            // 
            // criterioBusqueda
            // 
            this.criterioBusqueda.FormattingEnabled = true;
            this.criterioBusqueda.Location = new System.Drawing.Point(505, 38);
            this.criterioBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.criterioBusqueda.Name = "criterioBusqueda";
            this.criterioBusqueda.Size = new System.Drawing.Size(160, 24);
            this.criterioBusqueda.TabIndex = 3;
            this.criterioBusqueda.SelectedIndexChanged += new System.EventHandler(this.criterioBusqueda_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(684, 38);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(37, 90);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(729, 282);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.criterioBusqueda);
            this.Controls.Add(this.Text_info);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.btnListadoArt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Cargar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoArt;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Label Text_info;
        private System.Windows.Forms.ComboBox criterioBusqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

