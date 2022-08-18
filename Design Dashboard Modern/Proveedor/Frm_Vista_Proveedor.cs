using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;



namespace Design_Dashboard_Modern.Proveedor
{
    public partial class Frm_Vista_Proveedor : Form
    {
        public Frm_Vista_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Explo_Prod_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Los_Proveedor();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Configurar_ListVew()
        {
            var listVewMarca = listViewProveedor;

            listVewMarca.Items.Clear();
            listVewMarca.Columns.Clear();
            listVewMarca.View = View.Details;
            listVewMarca.GridLines = false;
            listVewMarca.FullRowSelect = true;
            listVewMarca.Scrollable = true;
            listVewMarca.HideSelection = false;
            listVewMarca.Columns.Add("ID", 80, HorizontalAlignment.Left);//0
            listVewMarca.Columns.Add("Nro Ruc", 90, HorizontalAlignment.Left);//1
            listVewMarca.Columns.Add("Nombre", 400, HorizontalAlignment.Left);//2
            listVewMarca.Columns.Add("Nro Cedula", 90, HorizontalAlignment.Left);//3
            listVewMarca.Columns.Add("Rubro", 180, HorizontalAlignment.Left);//4
            listVewMarca.Columns.Add("Direccion", 286, HorizontalAlignment.Left);//5
        }
        public void LLenar_ListVew(DataTable V)
        {
            listViewProveedor.Items.Clear();

            for (int i = 0; i < V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["IDPROVEE"].ToString());
                Lista.SubItems.Add(Dr["RUC"].ToString());
                Lista.SubItems.Add(Dr["NOMBRE"].ToString());
                Lista.SubItems.Add(Dr["TELEFONO"].ToString());
                Lista.SubItems.Add(Dr["RUBRO"].ToString());
                Lista.SubItems.Add(Dr["DIRECCION"].ToString());
                listViewProveedor.Items.Add(Lista);
            }

        }
        public void Cargar_Los_Proveedor()
        {
            RN_Proveedor Pro = new RN_Proveedor();
           
            DataTable CargarProveedr = new DataTable();

            CargarProveedr = Pro.RN_Mostrar_Proveerdor();

            if (CargarProveedr.Rows.Count > 0)
            {
                LLenar_ListVew(CargarProveedr);
            }
            else
            {
                listViewProveedor.Items.Clear();
            }
        }
        public void Buscar_Los_Proveedor(string V)
        {
            RN_Proveedor Pro = new RN_Proveedor();
            DataTable CargarProveedor = new DataTable();

            CargarProveedor = Pro.RN_Buscar_Proveerdor(V);

            if (CargarProveedor.Rows.Count > 0)
            {
                LLenar_ListVew(CargarProveedor);
            }
            else
            {
                listViewProveedor.Items.Clear();
            }
        }

        private void txt_buscar_proveedor_OnValueChanged(object sender, EventArgs e)
        {
             Buscar_Los_Proveedor(txt_buscar_proveedor.Text);
        }
        private void copiarIDProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            //Frm_Advertencia Advert = new Frm_Advertencia();

            if (listViewProveedor.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            {
                filtro.Show();
                MessageBox.Show("Seleccione el item que seas Copiar");
                //Advert.textBox1.Text = "Seleccione el item que seas Copiar"; ;
                //Advert.ShowDialog();
                filtro.Hide();
            }
            else
            {
                var lis = listViewProveedor.SelectedItems[0];
                string idProveedor = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idProveedor.Trim());

            }
        }


        private void buttonAgregarProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Fmr_Add_Proveedor Add = new Fmr_Add_Proveedor();

            filtro.Show();
            Add.ShowDialog();
            filtro.Hide();

            if (Add.Tag.ToString() == "A")
            {
                Cargar_Los_Proveedor();
            }
        }
       

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //Frm_Filtro filtro = new Frm_Filtro();
            //Fmr_Add_Proveedor Add = new Fmr_Add_Proveedor();

            //filtro.Show();
            //Add.ShowDialog();
            //filtro.Hide();

            //if (Add.Tag.ToString() == "A")
            //{
            //    Cargar_Los_Proveedor();
            //}
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_Filtro filtro = new Frm_Filtro();
            //Frm_Advertencia Advert = new Frm_Advertencia();
            //Fmr_Edit_Proveedor edit = new Fmr_Edit_Proveedor();

            //if (listViewProveedor.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            //{
            //    filtro.Show();
            //    Advert.textBox1.Text = "Seleccione el item que seas ediar"; ;
            //    Advert.ShowDialog();
            //    filtro.Hide();
            //}
            //else
            //{
            //    var lis = listViewProveedor.SelectedItems[0];
            //    string idProveedor = lis.SubItems[0].Text;

            //    filtro.Show();
            //    edit.Tag = idProveedor;
            //    edit.ShowDialog();
            //    filtro.Hide();

            //    if (edit.Tag.ToString() == "A")
            //    {
            //        Cargar_Los_Proveedor();
            //    }
            //}
        }

        private void buttonEditarProveedor_Click(object sender, EventArgs e)
        {
            //Frm_Filtro filtro = new Frm_Filtro();
            //Frm_Advertencia Advert = new Frm_Advertencia();
            //Fmr_Edit_Proveedor edit = new Fmr_Edit_Proveedor();

            //if (listViewProveedor.SelectedIndices.Count == 0)
            //{
            //    filtro.Show();
            //    Advert.textBox1.Text = "Seleccione el item que seas ediar"; ;
            //    Advert.ShowDialog();
            //    filtro.Hide();
            //}
            //else
            //{
            //    var lis = listViewProveedor.SelectedItems[0];
            //    string idProveedor = lis.SubItems[0].Text;

            //    filtro.Show();
            //    edit.Tag = idProveedor;
            //    edit.ShowDialog();
            //    filtro.Hide();

            //    if (edit.Tag.ToString() == "A")
            //    {
            //        Cargar_Los_Proveedor();
            //    }
            //}
        }
        
    }
}
