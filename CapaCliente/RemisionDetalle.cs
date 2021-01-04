using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaCliente;
using CapaNegocio;


namespace CapaCliente
{
    public partial class RemisionDetalle : Form
    {
        public int? id;
        public int? id2;
        public RemisionDetalle(int? id=null, int? id2 = null)
        {
            InitializeComponent();
            this.id = id;
            this.id2 = id2;
            
           
            limpiar();
        }

        NegocioRemisionEntrada metodosRemision = new NegocioRemisionEntrada();




        private int? GetIdForm() //RECOGER EL ID2 CON DATOS
        {
            //DAME EL ID
            try
            {
                return int.Parse(dataGridViewRDetalle.Rows[dataGridViewRDetalle.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }

        public void GetById(int? id2)
        {
            var datos = metodosRemision.getById(id2);

            foreach (var item in datos)
            {

                txtProducto.Text =Convert.ToString(item.IdProducto);
                txtCantidad.Text =Convert.ToString(item.Cantidad);
            }
        }


        public void LlenarGridDetalleRemision()
        {
            //var datos = metodosRemision.MostrarRemisionDetalle(id);
            var datos = metodosRemision.MostrarRemisionDetalleByRemision(id);
            dataGridViewRDetalle.DataSource = datos;

            labelDetalle.Text =Convert.ToString(id);

           


        }
        public void MostrarRemisionDetalleByRemision()
        {

      
            var datos = metodosRemision.MostrarRemisionDetalleByRemision(id);


            foreach (var item in datos)
            {

                txtProducto.Text = Convert.ToString(item.IdProducto);
                txtCantidad.Text = Convert.ToString(item.Cantidad);

            }


        }

        public void llenarInputs()
        { 
            id2 = GetIdForm();
            if (id2 != null)
            {
                GetById(id2); //PASARLE EL ID A LA CONSULTA
            }

        }

      
        public void limpiar()
        {
           
            txtProducto.Text = "";
            txtCantidad.Text = "";
            id2 = null;
        }

        public void Agregar()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtProducto.Text == "" || txtCantidad.Text == "" )
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var idProduct = Convert.ToInt32(txtProducto.Text);
                var verificar = metodosRemision.ProductoYRemision((int)id, idProduct);

              
                if (verificar)
                {
                    MessageBox.Show("Error, no puedes agregar el mismo producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }
                else
                {
                    int idRemisionEntrada = (int)id;
                    int idProducto = Convert.ToInt32(txtProducto.Text);
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    MessageBox.Show("Agregado Correctamente");
                    client.agregarRemisionDetalle(idRemisionEntrada, idProducto, cantidad);
                    LlenarGridDetalleRemision();
                }                
            }
        }
            
        public void Update()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var idProduct = Convert.ToInt32(txtProducto.Text);
                var verificar = metodosRemision.ProductoYRemision((int)id, idProduct);
                if (verificar)
                {
                    MessageBox.Show("Error, no puedes agregar el mismo producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }
                else
                {

                    int idRemisionEntrada = (int)id;
                    int idProducto = Convert.ToInt32(txtProducto.Text);
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    MessageBox.Show("Actualizado Correctamente");
                    client.updateRemisionDetalle(id2, idRemisionEntrada, idProducto, cantidad);
                }
            }
        }

        public void delete()
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
                    client.deleteRemisionDetalle(id2);
                  
                    limpiar();
                    id = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Exito!!..");
                }



            }

        }


        private void RemisionDetalle_Load(object sender, EventArgs e)
        {
         
            LlenarGridDetalleRemision();

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llenarDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            llenarInputs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Agregar();
            LlenarGridDetalleRemision();
            limpiar();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete();
            LlenarGridDetalleRemision();
            limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            LlenarGridDetalleRemision();
            limpiar();
        }

        public bool Confirmada()
        {
            var datos = metodosRemision.GetByIdRemision(id);
            var bandera = 0;
            
            foreach (var item in datos)
            {

                var estado = item.Estado;


                if (estado == 2)
                {
                    bandera = 1;
                }
                else
                {
                    bandera = 0;
                }
                
            }


            if (bandera == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            


        }

        public void InventarioFisico()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtProducto.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var datos = metodosRemision.GetByIdRemision(id);
                int idAlmacen = 0;
                foreach (var item in datos)
                {

                     idAlmacen = item.IdAlmacen;

                }


                int idProducto = Convert.ToInt32(txtProducto.Text);

                var datos2 = metodosRemision.GetByInventarioFisico(idAlmacen,idProducto);
                int cantidadTabla = 0;
                int idInventario = 0;
                foreach (var item in datos2)
                {
                    idInventario = item.Id;
                    cantidadTabla = item.Cantidad;
                }

                if (Confirmada())
                {
                    int cantidadProducto = Convert.ToInt32(txtCantidad.Text);
                    int suma = cantidadTabla + cantidadProducto;
                    client.inventarioFisico(idInventario, idAlmacen, idProducto,suma);
                    MessageBox.Show("Agregado Correctamente");


                    LlenarGridDetalleRemision();
                }
                else
                {
                    MessageBox.Show("Error, la Remision no esta confirmada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

           
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            InventarioFisico();


        }
    }
}
