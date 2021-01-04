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
using CapaDato;
namespace CapaCliente
{
    public partial class AllProducto : Form
    {

        public int? id;
        public AllProducto(int? id = null)
        {
            InitializeComponent();
            this.id = id;
        }
        NegocioProducto metodosProducto = new NegocioProducto();

        public void mostrarProductos()
        {
            var datos = metodosProducto.MostrarDatos();
            dataGridViewProductos.DataSource = datos;
        }

        private int? GetIdForm() //RECOGER EL ID CON DATOS
        {
            //DAME EL ID
            try
            {
                return int.Parse(dataGridViewProductos.Rows[dataGridViewProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }

        public void GetById(int? id) //RECOGER EL ID DE LA BASE DE DATOS Y LLENAR EL TEXT BOX
        {
            var datos = metodosProducto.GetByIdProducto(id);
            foreach (var item in datos)//RECORRER TEXT BOX PARA LLENAR 
            {
                txtCodigoProd.Text = item.Codigo;
                txtNombreProd.Text = item.Nombre;
                txtDescripcionProd.Text = item.Descripcion;
                txtVentaProd.Text = Convert.ToString(item.PrecioVenta);
                txtMinProd.Text = Convert.ToString(item.StockMinimo);
                txtMaxProd.Text = Convert.ToString(item.StockMaximo);
                labelid.Text = Convert.ToString(item.Id);

            }
        }
        public bool getCodigoProducto(string codigo)
        {

            var codigoResponse = metodosProducto.getCodigoProducto(codigo);
            return codigoResponse;


        }

        public void GuardarProducto()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtNombreProd.Text == "" || txtCodigoProd.Text == "" || txtDescripcionProd.Text == "" || txtVentaProd.Text == "" || txtMinProd.Text == ""|| txtMaxProd.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var verificar = getCodigoProducto(txtCodigoProd.Text);
                var verificarStock = metodosProducto.GetByIdProducto(id); 
                int stockminData=0;
                int stockmaxData=0;
                foreach (var item in verificarStock)
                {
                    stockminData = item.StockMinimo;
                    stockmaxData = item.StockMaximo;
                }


                if (verificar)
                {
                    MessageBox.Show("Error, ya existe este proveedor registrado con este codigo");
                    limpiar();
                }
                else
                {             
                    string Codigo = txtCodigoProd.Text;
                    string Nombre = txtNombreProd.Text;
                    string Descripcion = txtDescripcionProd.Text;
                    decimal PrecioVenta = Convert.ToDecimal(txtVentaProd.Text);
                    int stockMin = Convert.ToInt32(txtMinProd.Text);
                    int stockMaximo = Convert.ToInt32(txtMaxProd.Text);

                    if (stockminData>=stockMin && stockmaxData<=stockMaximo)
                    {
                      
                        MessageBox.Show("Agregado Correctamente");
                        client.agregarProducto(Codigo, Nombre, Descripcion, PrecioVenta, stockMin, stockMaximo);
                    }
                    else
                    {
                        MessageBox.Show("Error, no te pases del limite del stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }

            }
        }

        public void UpdateProducto()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtNombreProd.Text == "" || txtCodigoProd.Text == "" || txtVentaProd.Text == "" || txtMinProd.Text == "" || txtMaxProd.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var verificarStock = metodosProducto.GetByIdProducto(id);
                int stockminData = 0;
                int stockmaxData = 0;
                foreach (var item in verificarStock)
                {
                    stockminData = item.StockMinimo;
                    stockmaxData = item.StockMaximo;
                }


                var datos = metodosProducto.GetByIdProducto(id);
                foreach (var item in datos)//RECORRER TEXT BOX PARA LLENAR 
                {
                    id = item.Id;

                }


                string Codigo = txtCodigoProd.Text;
                string Nombre = txtNombreProd.Text;
                string Descripcion = txtDescripcionProd.Text;
                decimal PrecioVenta = Convert.ToDecimal(txtVentaProd.Text);

                int stockMin = Convert.ToInt32(txtMinProd.Text);
                int stockMaximo = Convert.ToInt32(txtMaxProd.Text);


                if (stockMin >= stockminData && stockMaximo  <= stockmaxData)
                {

                    MessageBox.Show("Actualizado Correctamente");
                    client.updateProducto(id, Codigo, Nombre, Descripcion, PrecioVenta, stockMin, stockMaximo);
                    mostrarProductos();
                }else
                {
                    MessageBox.Show("Error, no te pases del limite del stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 

              
                id = null;

            }
        }


        public void DeleteProducto()
        {

            if (id == null)
            {
                MessageBox.Show("Selecciona primero un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Quieres eliminar el registro?", "CRUD ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                    client.deleteProducto(id);
                    mostrarProductos();
                    limpiar();
                    id = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Exito!!..");
                }



            }
        }
        public void limpiar()
        {
            txtCodigoProd.Text ="";
            txtNombreProd.Text ="";
            txtDescripcionProd.Text ="";
            txtVentaProd.Text ="";
            txtMinProd.Text = "";
            txtMaxProd.Text = "";
            labelid.Text = "0";
            id = null;

        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllProducto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void llenarInputs(object sender, DataGridViewCellEventArgs e)
        {
            id = GetIdForm();
            if (id != null)
            {
                GetById(id); //PASARLE EL ID A LA CONSULTA
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                GuardarProducto();
            }
            else
            {
                UpdateProducto();
            }
            mostrarProductos();
            limpiar();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteProducto();
        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
