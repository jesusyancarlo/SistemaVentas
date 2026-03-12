using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.CargarCategoria();
        }

        private void CargarCategoria()
        {
            cboidcategoria.DataSource = CNCategoria.Listar();
            cboidcategoria.ValueMember = "idcategoria";
            cboidcategoria.DisplayMember = "descripcion";
        }

        public void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbinactivo.Checked == false)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }
            try
            {
                if (this.txtcodigo.Text == string.Empty || this.txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(this.txtcodigo.Text,
                                          this.txtnombre.Text,
                                          this.txtdescripcion.Text,
                                          this.dtfechaingreso.Value,
                                          this.dtfechavencimiento.Value,
                                          Convert.ToDouble(this.txtpreciocompra.Text),
                                          Convert.ToDouble(this.txtprecioventa.Text),
                                          Convert.ToInt32(this.txtcantidad.Text),
                                          estado,
                                          Convert.ToInt32(this.cboidcategoria.SelectedValue));
                        MessageBox.Show("Producto registrado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNProducto.Editar(Convert.ToInt32(this.txtidproducto.Text),
                                          this.txtcodigo.Text,
                                          this.txtnombre.Text,
                                          this.txtdescripcion.Text,
                                          this.dtfechaingreso.Value,
                                          this.dtfechavencimiento.Value,
                                          Convert.ToDouble(this.txtpreciocompra.Text),
                                          Convert.ToDouble(this.txtprecioventa.Text),
                                          Convert.ToInt32(this.txtcantidad.Text),
                                          estado,
                                          Convert.ToInt32(this.cboidcategoria.SelectedValue));
                        MessageBox.Show("Producto editado correctamente", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoProducto form = new FrmListadoProducto();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
        }
    }
}
