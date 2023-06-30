namespace pryIE1_SalasFranciscp
{
    partial class frmCargaVentas
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
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.lblConsultaCantidad = new System.Windows.Forms.Label();
            this.lblConsultaNombre = new System.Windows.Forms.Label();
            this.cmdConsulta1 = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsultaNombre = new System.Windows.Forms.TextBox();
            this.txtConsultaCantidad = new System.Windows.Forms.TextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.cmdCancelar);
            this.gbVentas.Controls.Add(this.cmdCargar);
            this.gbVentas.Controls.Add(this.txtCantidad);
            this.gbVentas.Controls.Add(this.lblCantidad);
            this.gbVentas.Controls.Add(this.dtpVenta);
            this.gbVentas.Controls.Add(this.lblFechaVenta);
            this.gbVentas.Controls.Add(this.txtNombre);
            this.gbVentas.Controls.Add(this.lblNombre);
            this.gbVentas.Controls.Add(this.txtID);
            this.gbVentas.Controls.Add(this.lblID);
            this.gbVentas.Location = new System.Drawing.Point(12, 12);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(220, 227);
            this.gbVentas.TabIndex = 0;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(57, 194);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(138, 194);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 11;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(9, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 145);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(126, 17);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad vendida: ";
            // 
            // dtpVenta
            // 
            this.dtpVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenta.Location = new System.Drawing.Point(6, 122);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(207, 20);
            this.dtpVenta.TabIndex = 8;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(6, 102);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(110, 17);
            this.lblFechaVenta.TabIndex = 7;
            this.lblFechaVenta.Text = "Fecha de venta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(145, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre del producto:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(6, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(207, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID del producto:";
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Location = new System.Drawing.Point(238, 68);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(142, 23);
            this.cmdConsulta.TabIndex = 2;
            this.cmdConsulta.Text = "Consultar";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // lblConsultaCantidad
            // 
            this.lblConsultaCantidad.AutoSize = true;
            this.lblConsultaCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCantidad.Location = new System.Drawing.Point(235, 25);
            this.lblConsultaCantidad.Name = "lblConsultaCantidad";
            this.lblConsultaCantidad.Size = new System.Drawing.Size(150, 17);
            this.lblConsultaCantidad.TabIndex = 13;
            this.lblConsultaCantidad.Text = "Consulta por cantidad:";
            // 
            // lblConsultaNombre
            // 
            this.lblConsultaNombre.AutoSize = true;
            this.lblConsultaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaNombre.Location = new System.Drawing.Point(241, 114);
            this.lblConsultaNombre.Name = "lblConsultaNombre";
            this.lblConsultaNombre.Size = new System.Drawing.Size(144, 17);
            this.lblConsultaNombre.TabIndex = 14;
            this.lblConsultaNombre.Text = "Consulta por nombre:";
            // 
            // cmdConsulta1
            // 
            this.cmdConsulta1.Location = new System.Drawing.Point(238, 160);
            this.cmdConsulta1.Name = "cmdConsulta1";
            this.cmdConsulta1.Size = new System.Drawing.Size(142, 23);
            this.cmdConsulta1.TabIndex = 15;
            this.cmdConsulta1.Text = "Consultar";
            this.cmdConsulta1.UseVisualStyleBackColor = true;
            this.cmdConsulta1.Click += new System.EventHandler(this.cmdConsulta1_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha,
            this.Cantidad});
            this.dgvConsultas.Location = new System.Drawing.Point(391, 12);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(505, 227);
            this.dgvConsultas.TabIndex = 16;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // txtConsultaNombre
            // 
            this.txtConsultaNombre.Location = new System.Drawing.Point(238, 134);
            this.txtConsultaNombre.Name = "txtConsultaNombre";
            this.txtConsultaNombre.Size = new System.Drawing.Size(142, 20);
            this.txtConsultaNombre.TabIndex = 17;
            // 
            // txtConsultaCantidad
            // 
            this.txtConsultaCantidad.Location = new System.Drawing.Point(238, 45);
            this.txtConsultaCantidad.Name = "txtConsultaCantidad";
            this.txtConsultaCantidad.Size = new System.Drawing.Size(142, 20);
            this.txtConsultaCantidad.TabIndex = 18;
            this.txtConsultaCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaCantidad_KeyPress);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(238, 216);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(142, 23);
            this.cmdLimpiar.TabIndex = 19;
            this.cmdLimpiar.Text = "Limpiar Grilla";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // frmCargaVentas
            // 
            this.AcceptButton = this.cmdCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 248);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtConsultaCantidad);
            this.Controls.Add(this.txtConsultaNombre);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.cmdConsulta1);
            this.Controls.Add(this.lblConsultaNombre);
            this.Controls.Add(this.lblConsultaCantidad);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.gbVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargaVentas";
            this.Text = "Cargar Ventas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdConsulta;
        private System.Windows.Forms.Label lblConsultaCantidad;
        private System.Windows.Forms.Label lblConsultaNombre;
        private System.Windows.Forms.Button cmdConsulta1;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.TextBox txtConsultaNombre;
        private System.Windows.Forms.TextBox txtConsultaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}