namespace pryIE1_SalasFranciscp
{
    partial class frmPrincipal
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
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdCargarVenta = new System.Windows.Forms.Button();
            this.cdmCargarProducto = new System.Windows.Forms.Button();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.cmdListar);
            this.gbOpciones.Controls.Add(this.cmdCargarVenta);
            this.gbOpciones.Controls.Add(this.cdmCargarProducto);
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(260, 176);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(59, 127);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(142, 43);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // cmdCargarVenta
            // 
            this.cmdCargarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVenta.Location = new System.Drawing.Point(59, 73);
            this.cmdCargarVenta.Name = "cmdCargarVenta";
            this.cmdCargarVenta.Size = new System.Drawing.Size(142, 43);
            this.cmdCargarVenta.TabIndex = 2;
            this.cmdCargarVenta.Text = "Cargar Venta";
            this.cmdCargarVenta.UseVisualStyleBackColor = true;
            this.cmdCargarVenta.Click += new System.EventHandler(this.cmdCargarVenta_Click);
            // 
            // cdmCargarProducto
            // 
            this.cdmCargarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmCargarProducto.Location = new System.Drawing.Point(59, 19);
            this.cdmCargarProducto.Name = "cdmCargarProducto";
            this.cdmCargarProducto.Size = new System.Drawing.Size(142, 43);
            this.cdmCargarProducto.TabIndex = 1;
            this.cdmCargarProducto.Text = "Cargar Producto";
            this.cdmCargarProducto.UseVisualStyleBackColor = true;
            this.cdmCargarProducto.Click += new System.EventHandler(this.cdmCargarProducto_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.gbOpciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdCargarVenta;
        private System.Windows.Forms.Button cdmCargarProducto;
    }
}