using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using CapaNegocio;


namespace CapaCliente
{
    public partial class AllProveedor : Form
    {

        public int? id;
        public AllProveedor(int? id = null)
        {
            InitializeComponent();

            this.id = id;
        }
        NegocioProveedor metodosNegocio = new NegocioProveedor();
        EntidadProveedor EntidadProveedor = new EntidadProveedor();
        private void dataGridViewProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void MostrarDatos()
        {

             var datos = metodosNegocio.MostrarDatos();
            dataGridViewProveedor.DataSource =  datos;

        }
        public  bool getCodigo(string codigo)
        {

            var codigoResponse = metodosNegocio.getCodigo(codigo);
            return codigoResponse;


        }

        public void AgregarProveedor()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var verificar = getCodigo(txtCodigo.Text);
                if (verificar)
                {
                    MessageBox.Show("Error, ya existe este proveedor registrado con este codigo");
                    limpiar();
                }
                else
                {
                    string Codigo = txtCodigo.Text;
                    string Nombre = txtNombre.Text;
                    string Direccion = txtDireccion.Text;
                    string Telefono = txtTelefono.Text;
                    MessageBox.Show("Agregado Correctamente");
                    client.agregarProveedor(Codigo, Nombre, Direccion, Telefono);
                }
              
            }

            
        }

 

        public void UpdateProveedor()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                    var datos = metodosNegocio.GetById(id);
                    foreach (var item in datos)//RECORRER TEXT BOX PARA LLENAR 
                    {
                        id = item.Id;

                    }


                    string Codigo = txtCodigo.Text;
                    string Nombre = txtNombre.Text;
                    string Direccion = txtDireccion.Text;
                    string Telefono = txtTelefono.Text;

                    MessageBox.Show("Actualizado Correctamente");
                    client.updateProveedor(id, Codigo, Nombre, Direccion, Telefono);
                    MostrarDatos();
                    limpiar();
                    id = null;
             

             
            }
        }
        private void AllProveedor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

      public void Delete()
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
                    client.deleteProveedor(id);
                    MostrarDatos();
                    limpiar();
                    id = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Exito!!..");
                }



            }
        }
        //BUSCAR POR ID
        private int? GetIdForm() //RECOGER EL ID CON DATOS
        {
            //DAME EL ID
            try
            {
                return int.Parse(dataGridViewProveedor.Rows[dataGridViewProveedor.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }

        public void GetById(int? id) //RECOGER EL ID DE LA BASE DE DATOS Y LLENAR EL TEXT BOX
        {
            var datos = metodosNegocio.GetById(id);
            foreach (var item in datos)//RECORRER TEXT BOX PARA LLENAR 
            {
                txtCodigo.Text = item.Codigo;
                txtNombre.Text = item.Nombre;               
                txtDireccion.Text = item.Direccion;
                txtTelefono.Text = item.Telefono;
                labelid.Text = Convert.ToString(item.Id);

            }
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
                AgregarProveedor();
            }
            else
            {
                UpdateProveedor();
            }

            MostrarDatos();
            limpiar();
        }

     

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            labelid.Text = "0";
            id = null;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportePreview form = new ReportePreview();
            form.Show();
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
