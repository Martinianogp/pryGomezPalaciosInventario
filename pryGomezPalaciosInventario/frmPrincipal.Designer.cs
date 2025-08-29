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
            tabControl1 = new TabControl();
            tabInicio = new TabPage();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            lblAgregar = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            txtNombre = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblStock = new Label();
            txtStock = new TextBox();
            lblDescripcion = new Label();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
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
            tabInicio.BackColor = Color.Ivory;
            tabInicio.Controls.Add(textBox1);
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
            tabInicio.Text = "Gestion";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(562, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(562, 342);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Reportes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregar.Location = new Point(30, 49);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(60, 21);
            lblAgregar.TabIndex = 0;
            lblAgregar.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(94, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(20, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(13, 144);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 21);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(94, 146);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(143, 23);
            cboCategoria.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(94, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(280, 48);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(339, 46);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 27);
            txtPrecio.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 263);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 31);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(203, 263);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 31);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(393, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(280, 97);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 21);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(339, 97);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(143, 27);
            txtStock.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(280, 148);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(377, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 27);
            textBox1.TabIndex = 15;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(698, 481);
            Controls.Add(tabControl1);
            Name = "frmPrincipal";
            Text = "Inicio";
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabInicio.PerformLayout();
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
        private TextBox textBox1;
        private Label lblDescripcion;
        private TextBox txtStock;
        private Label lblStock;
    }
}