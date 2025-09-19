namespace pryGomezPalaciosInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            tabControl1 = new TabControl();
            tabInicio = new TabPage();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblAgregar = new Label();
            tabPage2 = new TabPage();
            btnBuscar = new Button();
            txtDescripcionBuscar = new TextBox();
            lblDescripcionBuscar = new Label();
            txtNombreBuscar = new TextBox();
            lblNombreBuscar = new Label();
            txtCategoriaBuscar = new TextBox();
            lblCategoriaBuscar = new Label();
            lblCodigoBuscar = new Label();
            txtCodigoBuscar = new TextBox();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInicio);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(70, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(570, 370);
            tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            tabInicio.BackColor = Color.Wheat;
            tabInicio.Controls.Add(txtDescripcion);
            tabInicio.Controls.Add(lblDescripcion);
            tabInicio.Controls.Add(txtStock);
            tabInicio.Controls.Add(lblStock);
            tabInicio.Controls.Add(btnEliminar);
            tabInicio.Controls.Add(btnModificar);
            tabInicio.Controls.Add(btnAgregar);
            tabInicio.Controls.Add(txtPrecio);
            tabInicio.Controls.Add(lblPrecio);
            tabInicio.Controls.Add(txtNombre);
            tabInicio.Controls.Add(cboCategoria);
            tabInicio.Controls.Add(lblCategoria);
            tabInicio.Controls.Add(lblNombre);
            tabInicio.Controls.Add(txtCodigo);
            tabInicio.Controls.Add(lblAgregar);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(562, 342);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Gestión";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(283, 66);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(252, 189);
            txtDescripcion.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(283, 42);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripción";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(94, 227);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(143, 27);
            txtStock.TabIndex = 13;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(35, 227);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 21);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Wheat;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(393, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Wheat;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(203, 281);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 31);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Wheat;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(30, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 31);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(94, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 27);
            txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(35, 183);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(94, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 27);
            txtNombre.TabIndex = 6;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(94, 136);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(143, 23);
            cboCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(13, 134);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 21);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(20, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(94, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregar.Location = new Point(30, 43);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(60, 21);
            lblAgregar.TabIndex = 0;
            lblAgregar.Text = "Código";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Wheat;
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(txtDescripcionBuscar);
            tabPage2.Controls.Add(lblDescripcionBuscar);
            tabPage2.Controls.Add(txtNombreBuscar);
            tabPage2.Controls.Add(lblNombreBuscar);
            tabPage2.Controls.Add(txtCategoriaBuscar);
            tabPage2.Controls.Add(lblCategoriaBuscar);
            tabPage2.Controls.Add(lblCodigoBuscar);
            tabPage2.Controls.Add(txtCodigoBuscar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(562, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Wheat;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(119, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 31);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescripcionBuscar
            // 
            txtDescripcionBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcionBuscar.Location = new Point(119, 179);
            txtDescripcionBuscar.Multiline = true;
            txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            txtDescripcionBuscar.ReadOnly = true;
            txtDescripcionBuscar.Size = new Size(372, 146);
            txtDescripcionBuscar.TabIndex = 17;
            // 
            // lblDescripcionBuscar
            // 
            lblDescripcionBuscar.AutoSize = true;
            lblDescripcionBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionBuscar.Location = new Point(16, 181);
            lblDescripcionBuscar.Name = "lblDescripcionBuscar";
            lblDescripcionBuscar.Size = new Size(91, 21);
            lblDescripcionBuscar.TabIndex = 16;
            lblDescripcionBuscar.Text = "Descripción";
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreBuscar.Location = new Point(360, 46);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.ReadOnly = true;
            txtNombreBuscar.Size = new Size(131, 27);
            txtNombreBuscar.TabIndex = 8;
            // 
            // lblNombreBuscar
            // 
            lblNombreBuscar.AutoSize = true;
            lblNombreBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreBuscar.Location = new Point(286, 48);
            lblNombreBuscar.Name = "lblNombreBuscar";
            lblNombreBuscar.Size = new Size(68, 21);
            lblNombreBuscar.TabIndex = 7;
            lblNombreBuscar.Text = "Nombre";
            // 
            // txtCategoriaBuscar
            // 
            txtCategoriaBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoriaBuscar.Location = new Point(360, 113);
            txtCategoriaBuscar.Name = "txtCategoriaBuscar";
            txtCategoriaBuscar.ReadOnly = true;
            txtCategoriaBuscar.Size = new Size(131, 27);
            txtCategoriaBuscar.TabIndex = 6;
            // 
            // lblCategoriaBuscar
            // 
            lblCategoriaBuscar.AutoSize = true;
            lblCategoriaBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoriaBuscar.Location = new Point(277, 115);
            lblCategoriaBuscar.Name = "lblCategoriaBuscar";
            lblCategoriaBuscar.Size = new Size(77, 21);
            lblCategoriaBuscar.TabIndex = 5;
            lblCategoriaBuscar.Text = "Categoría";
            // 
            // lblCodigoBuscar
            // 
            lblCodigoBuscar.AutoSize = true;
            lblCodigoBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigoBuscar.Location = new Point(47, 48);
            lblCodigoBuscar.Name = "lblCodigoBuscar";
            lblCodigoBuscar.Size = new Size(60, 21);
            lblCodigoBuscar.TabIndex = 1;
            lblCodigoBuscar.Text = "Código";
            // 
            // txtCodigoBuscar
            // 
            txtCodigoBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoBuscar.Location = new Point(119, 46);
            txtCodigoBuscar.Name = "txtCodigoBuscar";
            txtCodigoBuscar.Size = new Size(131, 27);
            txtCodigoBuscar.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Wheat;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(562, 342);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Reportes";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(725, 481);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Inicio";
            Load += frmPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabInicio.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInicio;
        private TabPage tabPage2;
        private Label lblAgregar;
        private TabPage tabPage1;
        private Label lblCategoria;
        private Label lblNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private ComboBox cboCategoria;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblCodigoBuscar;
        private TextBox txtCodigoBuscar;
        private Label lblCategoriaBuscar;
        private TextBox txtDescripcionBuscar;
        private Label lblDescripcionBuscar;
        private TextBox txtNombreBuscar;
        private Label lblNombreBuscar;
        private TextBox txtCategoriaBuscar;
        private Button btnBuscar;
    }
}