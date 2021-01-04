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
    public partial class RemisonEntrada : Form
    {

        public int? id;

        public RemisonEntrada(int? id = null)
        {
            InitializeComponent();

            this.id = id;

        }

        NegocioRemisionEntrada metodosRemision = new NegocioRemisionEntrada();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Mostrar()
        {
            var datos = metodosRemision.MostrarRemisionesEntrada();
            dataGridViewRemisionEntrada.DataSource = datos;

        }

        public void GetByIdDetalle(int? id)
        {

            var datos = metodosRemision.MostrarByIdRemision(id);

        }


        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemisonEntrada_Load(object sender, EventArgs e)
        {
            Mostrar();

            radioButton1.Checked = true;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int? GetIdForm() //RECOGER EL ID CON DATOS
        {
            //DAME EL ID
            try
            {
                return int.Parse(dataGridViewRemisionEntrada.Rows[dataGridViewRemisionEntrada.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }

        }
        public void GetByIdRemision(int? id)
        {
            var datos = metodosRemision.GetByIdRemision(id);

            foreach (var item in datos)
            {
                txtCodigo.Text = item.Codigo;
                txtProveedor.Text = Convert.ToString(item.IdProveedor);
                txtAlmacen.Text = Convert.ToString(item.IdAlmacen);
                var estado = item.Estado;
                labelid.Text = Convert.ToString(item.Id);

                if (estado == 1)
                {
                    radioButton1.Checked = true;
                }
                else if (estado == 2)
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton3.Checked = true;
                }


            }

        }


        private void remisionDetalleId(object sender, DataGridViewCellEventArgs e)
        {

            id = GetIdForm();
            if (id != null)
            {
                GetByIdRemision(id); //PASARLE EL ID A LA CONSULTA
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            id = GetIdForm();
            if (id != null)
            {
                RemisionDetalle form = new RemisionDetalle(id);
                form.ShowDialog();

            }
        }
        public bool getCodigo(string codigo)
        {

            var codigoResponse = metodosRemision.getCodigoRemision(codigo);
            return codigoResponse;


        }
        public void AgregarRemision()
        {

          
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            if (txtCodigo.Text == "" || txtAlmacen.Text == "" || txtAlmacen.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*
                var verificar = getCodigo(txtCodigo.Text);

                if (verificar)
                {
                    MessageBox.Show("Error, ya existe esta remision con el codigo registrado");
                    limpiar();
                }
                else
                {
                    */
                    string Codigo = txtCodigo.Text;
                    int idProveedor = Convert.ToInt32(txtProveedor.Text);
                    int idAlmacen = Convert.ToInt32(txtAlmacen.Text);
                    MessageBox.Show("Agregado Correctamente");
                    client.agregarRemision(Codigo, idProveedor, idAlmacen, 1);
             /*   }*/

            }


        }

        public void UpdateRemision()
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            if (txtCodigo.Text == "" || txtAlmacen.Text == "" || txtAlmacen.Text == "")
            {
                MessageBox.Show("Error, Hay datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                var datos = metodosRemision.GetByIdRemision(id);
                foreach (var item in datos)//RECORRER TEXT BOX PARA LLENAR 
                {
                   id = item.Id;

                }

                string Codigo = txtCodigo.Text;
                int idProveedor = Convert.ToInt32(txtProveedor.Text);
                int idAlmacen = Convert.ToInt32(txtAlmacen.Text);
                int estado = 1;

                if (radioButton1.Checked)
                {
                    estado = 1;
                }
                if (radioButton2.Checked)
                {
                    estado = 2;
                }
                if (radioButton3.Checked)
                {

                    estado = 3;
                }

                MessageBox.Show("Actualizado Correctamente");
                client.updateRemision((int)id, Codigo, idProveedor, idAlmacen, estado);

                Mostrar();
                id = null;

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                AgregarRemision();
            }
            else
            {
                UpdateRemision();
            }

            Mostrar();
            limpiar();


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
                    client.deleteRemision(id);
                    Mostrar();
                    limpiar();
                    id = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Exito!!..");
                }



            }

        }
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtProveedor.Text = "";
            txtAlmacen.Text = "";
            radioButton1.Checked = true;
            labelid.Text = "0";
            id = null;
           
        }

        private void dropDownButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportePreview2 reporte2 = new ReportePreview2();
            reporte2.Show();
        }
    }
}
