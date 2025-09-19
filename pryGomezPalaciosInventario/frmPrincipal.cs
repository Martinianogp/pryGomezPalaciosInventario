using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGomezPalaciosInventario
{
    public partial class frmPrincipal : Form
    {
        clsConexionBD clsConexionBd = new clsConexionBD();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexionBd.ConectarBD();
            clsConexionBd.cargarCategorias(cboCategoria);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                string categoria = cboCategoria.SelectedItem?.ToString();
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string descripcion = txtDescripcion.Text;

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = clsConexionBd.coneccionBaseDatos;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Productos1 (codigo_producto, nombre_producto, marca_nombre, precio, stock, descripcion) " +
                                  "VALUES (?, ?, ?, ?, ?, ?)";

                cmd.Parameters.AddWithValue("?", codigo);
                cmd.Parameters.AddWithValue("?", nombre);
                cmd.Parameters.AddWithValue("?", categoria);
                cmd.Parameters.AddWithValue("?", precio);
                cmd.Parameters.AddWithValue("?", stock);
                cmd.Parameters.AddWithValue("?", descripcion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                string categoria = cboCategoria.SelectedItem?.ToString();
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                string descripcion = txtDescripcion.Text;

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = clsConexionBd.coneccionBaseDatos;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Productos1 SET nombre_producto=?, marca_nombre=?, precio=?, stock=?, descripcion=? WHERE codigo_producto=?";

                cmd.Parameters.AddWithValue("?", nombre);
                cmd.Parameters.AddWithValue("?", categoria);
                cmd.Parameters.AddWithValue("?", precio);
                cmd.Parameters.AddWithValue("?", stock);
                cmd.Parameters.AddWithValue("?", descripcion);
                cmd.Parameters.AddWithValue("?", codigo);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Producto modificado correctamente.");
                else
                    MessageBox.Show("No se encontró el producto con ese código.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = clsConexionBd.coneccionBaseDatos;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Productos1 WHERE codigo_producto=?";
                cmd.Parameters.AddWithValue("?", codigo);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Producto eliminado correctamente.");
                else
                    MessageBox.Show("No se encontró el producto con ese código.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de producto.");
                return;
            }

            try
            {
                string consulta = "SELECT categoria_de_producto, marca_nombre, observaciones " +
                                  "FROM Productos WHERE codigo_producto = ?";

                using (OleDbCommand cmd = new OleDbCommand(consulta, clsConexionBd.coneccionBaseDatos))
                {
                    cmd.Parameters.AddWithValue("?", txtCodigoBuscar.Text);

                    // Abrimos la conexión si no está abierta
                    if (clsConexionBd.coneccionBaseDatos.State != System.Data.ConnectionState.Open)
                        clsConexionBd.coneccionBaseDatos.Open();

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        var fila = dt.Rows[0];
                        txtCategoriaBuscar.Text = fila["categoria_de_producto"].ToString();
                        txtNombreBuscar.Text = fila["marca_nombre"].ToString();
                        txtDescripcionBuscar.Text = fila["observaciones"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe.");
                        txtCategoriaBuscar.Clear();
                        txtNombreBuscar.Clear();
                        txtDescripcionBuscar.Clear();
                    }

                    clsConexionBd.coneccionBaseDatos.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
